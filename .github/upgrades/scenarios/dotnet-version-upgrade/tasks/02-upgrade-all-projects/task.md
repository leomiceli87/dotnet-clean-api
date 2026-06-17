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

## Research Findings

**Package Management Mode**: Standard (non-CPM) — versions are defined directly in project files.

**Project Files Modified**:
- CleanApi.API\CleanApi.API.csproj
- CleanApi.Application\CleanApi.Application.csproj
- CleanApi.Domain\CleanApi.Domain.csproj
- CleanApi.Infrastructure\CleanApi.Infrastructure.csproj

**TFM Updates**: All projects updated from net8.0 to net10.0

**Package Updates Applied**:
- CleanApi.API: Microsoft.AspNetCore.OpenApi (8.0.27 → 10.0.9), Microsoft.EntityFrameworkCore.Design (8.0.11 → 10.0.9)
- CleanApi.Infrastructure: Microsoft.EntityFrameworkCore (8.0.11 → 10.0.9), Microsoft.EntityFrameworkCore.Sqlite (8.0.11 → 10.0.9)
- Swashbuckle.AspNetCore remained at 6.6.2 (already compatible)

**Build Result**: ✅ Solution builds successfully with zero errors and zero warnings

**Done when**: All project files specify net10.0 as target framework, all packages updated to .NET 10.0-compatible versions, solution builds with zero errors and zero warnings, all 298 APIs analyzed are compatible
