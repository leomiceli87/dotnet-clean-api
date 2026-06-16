# 01-prerequisites: Verify SDK and global.json compatibility

Validate that the .NET 10.0 SDK is installed on the development machine and verify any global.json files in the solution are compatible with .NET 10.0. The global.json file (if present) may pin to a specific SDK version that needs updating to support .NET 10.0 target framework compilation.

This task ensures the build environment is ready before making any project changes. Projects targeting .NET 10.0 require the corresponding SDK version to compile successfully.

**Done when**: .NET 10.0 SDK installation confirmed, global.json files (if any) updated to allow .NET 10.0 SDK versions, validation passes without errors
