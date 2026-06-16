# 02-upgrade-all-projects: Update all projects to .NET 10.0

Update target framework monikers (TFM) from net8.0 to net10.0 across all four projects, upgrade NuGet packages to their .NET 10.0-compatible versions, and address any compilation issues that arise from the framework or package changes.

**Projects in scope:**
- CleanApi.API (ASP.NET Core web application)
- CleanApi.Application (application layer class library)
- CleanApi.Domain (domain model class library)
- CleanApi.Infrastructure (data access class library)

**Package updates required:**
- Microsoft.AspNetCore.OpenApi: 8.0.27 → 10.0.9
- Microsoft.EntityFrameworkCore: 8.0.11 → 10.0.9
- Microsoft.EntityFrameworkCore.Design: 8.0.11 → 10.0.9
- Microsoft.EntityFrameworkCore.Sqlite: 8.0.11 → 10.0.9

The assessment shows no binary or source incompatible API changes, so code modifications should be minimal or none. All projects are SDK-style format, which simplifies the TFM update process.

**Done when**: All project files specify net10.0 as target framework, all packages updated to .NET 10.0-compatible versions, solution builds with zero errors and zero warnings, all 298 APIs analyzed are compatible
