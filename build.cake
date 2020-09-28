var target = Argument("target", "Default");
var config = Argument("config", "Release");

////////////////////////////////////////////////////////////////
// Tasks

Task("Build")
    .Does(() => 
{
    DotNetCoreBuild("./src/Example.sln", new DotNetCoreBuildSettings {
        Configuration = config,
    });
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() => 
{
    DotNetCoreTest("./src/Example.sln", new DotNetCoreTestSettings {
        Configuration = config,
    });
});

////////////////////////////////////////////////////////////////
// Targets

Task("Default")
    .IsDependentOn("Test");

////////////////////////////////////////////////////////////////
// Execution

RunTarget(target);