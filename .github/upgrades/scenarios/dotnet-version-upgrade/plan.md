# .NET 10.0 Upgrade Plan

## Overview

**Target**: Upgrade CleanApi solution from .NET 8.0 to .NET 10.0 (LTS)
**Scope**: 4 projects, ~245 LOC, low risk upgrade with package updates

### Selected Strategy
**All-At-Once** — All projects upgraded simultaneously in a single atomic operation.
**Rationale**: Small solution (4 projects), all on .NET 8.0, clear dependency structure with minimal complexity. Package updates are mechanical (EF Core, ASP.NET Core OpenAPI) with no breaking API changes detected.

## Tasks

### 01-prerequisites: Verify SDK and global.json compatibility

Validate that the .NET 10.0 SDK is installed on the development machine and verify any global.json files in the solution are compatible with .NET 10.0. The global.json file (if present) may pin to a specific SDK version that needs updating to support .NET 10.0 target framework compilation.

This task ensures the build environment is ready before making any project changes. Projects targeting .NET 10.0 require the corresponding SDK version to compile successfully.

**Done when**: .NET 10.0 SDK installation confirmed, global.json files (if any) updated to allow .NET 10.0 SDK versions, validation passes without errors

---

### 02-upgrade-all-projects: Update all projects to .NET 10.0

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

---

### 03-final-validation: Validate solution integrity

Execute a full solution build, run the complete test suite to verify behavioral compatibility, and document the upgrade completion. This task confirms that the upgrade was successful and the solution is ready for deployment on .NET 10.0 runtime.

Verify that all projects build cleanly, dependencies resolve correctly, and tests pass without failures. Address any runtime behavioral differences introduced by .NET 10.0 framework changes or updated package versions.

**Done when**: Full solution builds successfully with zero errors and zero warnings, all existing tests pass, no runtime exceptions in smoke testing, upgrade artifacts documented in execution log
