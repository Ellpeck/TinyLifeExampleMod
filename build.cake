using System.Diagnostics;
using System.Linq;
using System.Threading;

var target = Argument("target", "Run");
var config = Argument("configuration", "Release");

var tinyLifeDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}/Tiny Life";

Task("Build").Does(() => {
    foreach (var project in GetFiles("**/*.csproj"))
        DotNetBuild(project.FullPath, new DotNetBuildSettings { Configuration = config });
});

Task("CopyToMods").IsDependentOn("Build").Does(() => {
    var dir = $"{tinyLifeDir}/Mods";
    CreateDirectory(dir);
    var files = GetFiles($"bin/{config}/net*/**/*");
    CopyFiles(files, dir, true);
});

Task("Run").IsDependentOn("CopyToMods").Does(() => {
    // start the tiny life process
    var exeDir = $"{tinyLifeDir}/GameDir";
    if (!FileExists(exeDir))
        throw new Exception("Didn't find game directory information. Run the game manually at least once to allow the Run task to be executed.");
    var exe = $"{System.IO.File.ReadAllText(exeDir)}/Tiny Life";
    var process = Process.Start(new ProcessStartInfo(exe) {
        CreateNoWindow = true
    });

    // we wait a bit to make sure the process has generated a new log file, bleh
    Thread.Sleep(1000);

    // attach to the newest log file
    var logsDir = $"{tinyLifeDir}/Logs";
    var log = System.IO.Directory.EnumerateFiles(logsDir).OrderByDescending(System.IO.File.GetCreationTime).FirstOrDefault();
    if (log != null) {
        using (var stream = new FileStream(log, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
            using (var reader = new StreamReader(stream)) {
                var lastPos = 0L;
                while (!process.HasExited) {
                    if (reader.BaseStream.Length > lastPos) {
                        reader.BaseStream.Seek(lastPos, SeekOrigin.Begin);
                        string line;
                        while ((line = reader.ReadLine()) != null)
                            Information(line);
                        lastPos = reader.BaseStream.Position;
                    }
                    Thread.Sleep(10);
                }
            }
        }
    }

    Information($"Tiny Life exited with exit code {process.ExitCode}");
});

Task("Publish").IsDependentOn("Build").Does(() => {
    foreach (var dir in GetDirectories($"bin/{config}/net*")) {
        var dllFile = GetFiles($"{dir}/**/*.dll").FirstOrDefault();
        if (dllFile == null) {
            Warning($"Couldn't find built mod in {dir}");
            continue;
        }
        var dllName = System.IO.Path.GetFileNameWithoutExtension(dllFile.ToString());
        var zipLoc = $"{dir.GetParent()}/{dllName}.zip";
        Zip(dir, zipLoc, GetFiles($"{dir}/**/*"));
        Information($"Published {dllName} to {zipLoc}");
    }
});

RunTarget(target);
