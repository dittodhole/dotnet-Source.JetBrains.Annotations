var artifactsDirectory = Directory("../artifacts");
var sourceDirectory = Directory("../src");
var solutionFile = sourceDirectory + File("JetBrains.Annotations.sln");

Task("Build")
  .IsDependentOn("Clean")
  .Does(() =>
{
  Information($"Building {MakeAbsolute(solutionFile)}");

  MSBuild(solutionFile,
          settings => settings.SetConfiguration("Release")
                              .SetVerbosity(Verbosity.Minimal)
                              .WithRestore()
                              .WithProperty("PackageOutputPath", MakeAbsolute(artifactsDirectory).FullPath));

  MSBuild(solutionFile,
          settings => settings.SetConfiguration("SourcePackage")
                              .SetVerbosity(Verbosity.Minimal)
                              .WithRestore()
                              .WithProperty("PackageOutputPath", MakeAbsolute(artifactsDirectory).FullPath));
});

Task("Clean")
  .Does(() =>
{
  Information($"Cleaning {MakeAbsolute(artifactsDirectory)}");

  if (DirectoryExists(artifactsDirectory))
  {
    DeleteDirectory(artifactsDirectory,
                    new DeleteDirectorySettings
                    {
                      Recursive = true
                    });
  }

  CreateDirectory(artifactsDirectory);
});

var targetArgument = Argument("target", "Build");
RunTarget(targetArgument);
