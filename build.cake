using System.Diagnostics;
using System.Linq;
using System.Threading;

var target = Argument("target", "Run");
var config = Argument("configuration", "Release");

var tinyLifeDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}/Tiny Life";

Task("Build").DoesForEach(GetFiles("**/*.csproj"), p => {
    DotNetBuild(p.FullPath, new DotNetBuildSettings { Configuration = config });
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

Task("Publish").IsDependentOn("Build").DoesForEach(GetDirectories($"bin/{config}/net*"), d => {
    var dllFile = GetFiles($"{d}/**/*.dll").FirstOrDefault();
    if (dllFile == null)
        throw new Exception($"Couldn't find built mod in {d}");
    var dllName = System.IO.Path.GetFileNameWithoutExtension(dllFile.ToString());
    var zipLoc = $"{d.GetParent()}/{dllName}.zip";
    Zip(d, zipLoc, GetFiles($"{d}/**/*"));
    Information($"Published {dllName} to {zipLoc}");
});

RunTarget(target);
