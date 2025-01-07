#addin nuget:?package=Cake.Incubator&version=8.0.0

using System.Diagnostics;
using System.Linq;
using System.Threading;

var target = Argument("target", "Run");
var config = Argument("configuration", "Release");
var userArgs = Argument("args", "");
var projectFile = Argument("project", GetFiles("**/*.csproj").FirstOrDefault());

var project = ParseProject(projectFile, config);
var outputPath = project.OutputPaths.FirstOrDefault();
var tinyLifeDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}/Tiny Life";

Task("Clean").Does(() => {
    EnsureDirectoryDoesNotExist($"bin/{config}");
    EnsureDirectoryDoesNotExist($"{tinyLifeDir}/Mods/_Dev");
});

Task("Build").Does(() => {
    DotNetBuild(projectFile.FullPath, new DotNetBuildSettings {
        Configuration = config
    });
});

Task("CopyToMods").IsDependentOn("Build").Does(() => {
    var dir = $"{tinyLifeDir}/Mods/_Dev";
    EnsureDirectoryExists(dir);
    var files = GetFiles($"bin/{config}/net*/**/*");
    CopyFiles(files, dir, true);
});

Task("Run").IsDependentOn("CopyToMods").Does(() => {
    // start the tiny life process
    var exeDir = System.IO.File.ReadAllText($"{tinyLifeDir}/GameDir");
    var process = Process.Start(new ProcessStartInfo($"{exeDir}/Tiny Life") {
        Arguments = $"-v --skip-splash --skip-preloads --debug-saves --ansi {userArgs}",
        RedirectStandardOutput = true,
        RedirectStandardError = true
    });
    // make sure the output buffers (which we ignore) don't fill up
    process.BeginOutputReadLine();
    process.BeginErrorReadLine();

    // we wait a bit to make sure the process has generated a new log file
    Thread.Sleep(1000);

    // attach to the newest log file
    var logsDir = $"{tinyLifeDir}/Logs";
    var log = System.IO.Directory.EnumerateFiles(logsDir).OrderByDescending(System.IO.File.GetCreationTime).FirstOrDefault();
    if (log != null) {
        using (var stream = new FileStream(log, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
            using (var reader = new StreamReader(stream)) {
                var lastPos = 0L;
                do {
                    if (stream.Length > lastPos) {
                        stream.Seek(lastPos, SeekOrigin.Begin);
                        string line;
                        while ((line = reader.ReadLine()) != null)
                            Information(line);
                        lastPos = stream.Position;
                    }
                    Thread.Sleep(10);
                } while (!process.HasExited);
            }
        }
    }

    Information($"Tiny Life exited with exit code {process.ExitCode}");
});

Task("Publish").IsDependentOn("Build").Does(() => {
    var zipLoc = $"{outputPath.GetParent()}/{project.AssemblyName}.zip";
    Zip(outputPath, zipLoc, GetFiles($"{outputPath}/**/*"));
    Information($"Published {project.AssemblyName} to {zipLoc}");
});

RunTarget(target);
