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
var zipOutputPath = $"{outputPath.GetParent()}/{project.AssemblyName}.zip";
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

Task("Zip").IsDependentOn("Build").Does(() => {
    Zip(outputPath, zipOutputPath, GetFiles($"{outputPath}/**/*"));
    Information($"Created zip archive {zipOutputPath}");
});

Task("CopyToMods").IsDependentOn("Zip").Does(() => {
    var dir = $"{tinyLifeDir}/Mods/_Dev";
    EnsureDirectoryExists(dir);
    CopyFileToDirectory(zipOutputPath, dir);
});

Task("Run").IsDependentOn("CopyToMods").Does(() => {
    var logsDir = $"{tinyLifeDir}/Logs";
    var lastLogs = System.IO.Directory.EnumerateFiles(logsDir).ToHashSet();

    // start the tiny life process
    var exeDir = System.IO.File.ReadAllText($"{tinyLifeDir}/GameDir");
    var process = Process.Start(new ProcessStartInfo($"{exeDir}/TinyLife") {
        Arguments = $"-v --trace-load --skip-splash --skip-preloads --debug-saves --ansi {userArgs}",
        RedirectStandardOutput = true,
        RedirectStandardError = true
    });
    // make sure the output buffers (which we ignore) don't fill up
    process.BeginOutputReadLine();
    process.BeginErrorReadLine();

    // wait for a new log file to be generated
    string log;
    do {
        log = System.IO.Directory.EnumerateFiles(logsDir).FirstOrDefault(l => !lastLogs.Contains(l));
        if (log != null)
            break;
        Thread.Sleep(100);
    } while (!process.HasExited);

    // attach to the log file
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

RunTarget(target);
