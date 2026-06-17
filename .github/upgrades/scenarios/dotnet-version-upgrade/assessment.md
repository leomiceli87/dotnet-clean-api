# Projects and dependencies analysis

This document provides a comprehensive overview of the projects and their dependencies in the context of upgrading to .NETCoreApp,Version=v10.0.

## Table of Contents

- [Executive Summary](#executive-Summary)
  - [Highlevel Metrics](#highlevel-metrics)
  - [Projects Compatibility](#projects-compatibility)
  - [Package Compatibility](#package-compatibility)
  - [API Compatibility](#api-compatibility)
- [Aggregate NuGet packages details](#aggregate-nuget-packages-details)
- [Top API Migration Challenges](#top-api-migration-challenges)
  - [Technologies and Features](#technologies-and-features)
  - [Most Frequent API Issues](#most-frequent-api-issues)
- [Projects Relationship Graph](#projects-relationship-graph)
- [Project Details](#project-details)

  - [CleanApi.API\CleanApi.API.csproj](#cleanapiapicleanapiapicsproj)
  - [CleanApi.Application\CleanApi.Application.csproj](#cleanapiapplicationcleanapiapplicationcsproj)
  - [CleanApi.Domain\CleanApi.Domain.csproj](#cleanapidomaincleanapidomaincsproj)
  - [CleanApi.Infrastructure\CleanApi.Infrastructure.csproj](#cleanapiinfrastructurecleanapiinfrastructurecsproj)


## Executive Summary

### Highlevel Metrics

| Metric | Count | Status |
| :--- | :---: | :--- |
| Total Projects | 4 | All require upgrade |
| Total NuGet Packages | 5 | 4 need upgrade |
| Total Code Files | 10 |  |
| Total Code Files with Incidents | 4 |  |
| Total Lines of Code | 245 |  |
| Total Number of Issues | 8 |  |
| Estimated LOC to modify | 0+ | at least 0,0% of codebase |

### Projects Compatibility

| Project | Target Framework | Difficulty | Package Issues | API Issues | Est. LOC Impact | Description |
| :--- | :---: | :---: | :---: | :---: | :---: | :--- |
| [CleanApi.API\CleanApi.API.csproj](#cleanapiapicleanapiapicsproj) | net8.0 | 🟢 Low | 2 | 0 |  | AspNetCore, Sdk Style = True |
| [CleanApi.Application\CleanApi.Application.csproj](#cleanapiapplicationcleanapiapplicationcsproj) | net8.0 | 🟢 Low | 0 | 0 |  | ClassLibrary, Sdk Style = True |
| [CleanApi.Domain\CleanApi.Domain.csproj](#cleanapidomaincleanapidomaincsproj) | net8.0 | 🟢 Low | 0 | 0 |  | ClassLibrary, Sdk Style = True |
| [CleanApi.Infrastructure\CleanApi.Infrastructure.csproj](#cleanapiinfrastructurecleanapiinfrastructurecsproj) | net8.0 | 🟢 Low | 2 | 0 |  | ClassLibrary, Sdk Style = True |

### Package Compatibility

| Status | Count | Percentage |
| :--- | :---: | :---: |
| ✅ Compatible | 1 | 20,0% |
| ⚠️ Incompatible | 0 | 0,0% |
| 🔄 Upgrade Recommended | 4 | 80,0% |
| ***Total NuGet Packages*** | ***5*** | ***100%*** |

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 298 |  |
| ***Total APIs Analyzed*** | ***298*** |  |

## Aggregate NuGet packages details

| Package | Current Version | Suggested Version | Projects | Description |
| :--- | :---: | :---: | :--- | :--- |
| Microsoft.AspNetCore.OpenApi | 8.0.27 | 10.0.9 | [CleanApi.API.csproj](#cleanapiapicleanapiapicsproj) | NuGet package upgrade is recommended |
| Microsoft.EntityFrameworkCore | 8.0.11 | 10.0.9 | [CleanApi.Infrastructure.csproj](#cleanapiinfrastructurecleanapiinfrastructurecsproj) | NuGet package upgrade is recommended |
| Microsoft.EntityFrameworkCore.Design | 8.0.11 | 10.0.9 | [CleanApi.API.csproj](#cleanapiapicleanapiapicsproj) | NuGet package upgrade is recommended |
| Microsoft.EntityFrameworkCore.Sqlite | 8.0.11 | 10.0.9 | [CleanApi.Infrastructure.csproj](#cleanapiinfrastructurecleanapiinfrastructurecsproj) | NuGet package upgrade is recommended |
| Swashbuckle.AspNetCore | 6.6.2 |  | [CleanApi.API.csproj](#cleanapiapicleanapiapicsproj) | ✅Compatible |

## Top API Migration Challenges

### Technologies and Features

| Technology | Issues | Percentage | Migration Path |
| :--- | :---: | :---: | :--- |

### Most Frequent API Issues

| API | Count | Percentage | Category |
| :--- | :---: | :---: | :--- |

## Projects Relationship Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart LR
    P1["<b>📦&nbsp;CleanApi.API.csproj</b><br/><small>net8.0</small>"]
    P2["<b>📦&nbsp;CleanApi.Application.csproj</b><br/><small>net8.0</small>"]
    P3["<b>📦&nbsp;CleanApi.Domain.csproj</b><br/><small>net8.0</small>"]
    P4["<b>📦&nbsp;CleanApi.Infrastructure.csproj</b><br/><small>net8.0</small>"]
    P1 --> P2
    P1 --> P4
    P2 --> P3
    P4 --> P2
    click P1 "#cleanapiapicleanapiapicsproj"
    click P2 "#cleanapiapplicationcleanapiapplicationcsproj"
    click P3 "#cleanapidomaincleanapidomaincsproj"
    click P4 "#cleanapiinfrastructurecleanapiinfrastructurecsproj"

```

## Project Details

<a id="cleanapiapicleanapiapicsproj"></a>
### CleanApi.API\CleanApi.API.csproj

#### Project Info

- **Current Target Framework:** net8.0
- **Proposed Target Framework:** net10.0
- **SDK-style**: True
- **Project Kind:** AspNetCore
- **Dependencies**: 2
- **Dependants**: 0
- **Number of Files**: 5
- **Number of Files with Incidents**: 1
- **Lines of Code**: 87
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["CleanApi.API.csproj"]
        MAIN["<b>📦&nbsp;CleanApi.API.csproj</b><br/><small>net8.0</small>"]
        click MAIN "#cleanapiapicleanapiapicsproj"
    end
    subgraph downstream["Dependencies (2"]
        P2["<b>📦&nbsp;CleanApi.Application.csproj</b><br/><small>net8.0</small>"]
        P4["<b>📦&nbsp;CleanApi.Infrastructure.csproj</b><br/><small>net8.0</small>"]
        click P2 "#cleanapiapplicationcleanapiapplicationcsproj"
        click P4 "#cleanapiinfrastructurecleanapiinfrastructurecsproj"
    end
    MAIN --> P2
    MAIN --> P4

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 151 |  |
| ***Total APIs Analyzed*** | ***151*** |  |

<a id="cleanapiapplicationcleanapiapplicationcsproj"></a>
### CleanApi.Application\CleanApi.Application.csproj

#### Project Info

- **Current Target Framework:** net8.0
- **Proposed Target Framework:** net10.0
- **SDK-style**: True
- **Project Kind:** ClassLibrary
- **Dependencies**: 1
- **Dependants**: 2
- **Number of Files**: 3
- **Number of Files with Incidents**: 1
- **Lines of Code**: 37
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph upstream["Dependants (2)"]
        P1["<b>📦&nbsp;CleanApi.API.csproj</b><br/><small>net8.0</small>"]
        P4["<b>📦&nbsp;CleanApi.Infrastructure.csproj</b><br/><small>net8.0</small>"]
        click P1 "#cleanapiapicleanapiapicsproj"
        click P4 "#cleanapiinfrastructurecleanapiinfrastructurecsproj"
    end
    subgraph current["CleanApi.Application.csproj"]
        MAIN["<b>📦&nbsp;CleanApi.Application.csproj</b><br/><small>net8.0</small>"]
        click MAIN "#cleanapiapplicationcleanapiapplicationcsproj"
    end
    subgraph downstream["Dependencies (1"]
        P3["<b>📦&nbsp;CleanApi.Domain.csproj</b><br/><small>net8.0</small>"]
        click P3 "#cleanapidomaincleanapidomaincsproj"
    end
    P1 --> MAIN
    P4 --> MAIN
    MAIN --> P3

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 15 |  |
| ***Total APIs Analyzed*** | ***15*** |  |

<a id="cleanapidomaincleanapidomaincsproj"></a>
### CleanApi.Domain\CleanApi.Domain.csproj

#### Project Info

- **Current Target Framework:** net8.0
- **Proposed Target Framework:** net10.0
- **SDK-style**: True
- **Project Kind:** ClassLibrary
- **Dependencies**: 0
- **Dependants**: 1
- **Number of Files**: 2
- **Number of Files with Incidents**: 1
- **Lines of Code**: 45
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph upstream["Dependants (1)"]
        P2["<b>📦&nbsp;CleanApi.Application.csproj</b><br/><small>net8.0</small>"]
        click P2 "#cleanapiapplicationcleanapiapplicationcsproj"
    end
    subgraph current["CleanApi.Domain.csproj"]
        MAIN["<b>📦&nbsp;CleanApi.Domain.csproj</b><br/><small>net8.0</small>"]
        click MAIN "#cleanapidomaincleanapidomaincsproj"
    end
    P2 --> MAIN

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 49 |  |
| ***Total APIs Analyzed*** | ***49*** |  |

<a id="cleanapiinfrastructurecleanapiinfrastructurecsproj"></a>
### CleanApi.Infrastructure\CleanApi.Infrastructure.csproj

#### Project Info

- **Current Target Framework:** net8.0
- **Proposed Target Framework:** net10.0
- **SDK-style**: True
- **Project Kind:** ClassLibrary
- **Dependencies**: 1
- **Dependants**: 1
- **Number of Files**: 3
- **Number of Files with Incidents**: 1
- **Lines of Code**: 76
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph upstream["Dependants (1)"]
        P1["<b>📦&nbsp;CleanApi.API.csproj</b><br/><small>net8.0</small>"]
        click P1 "#cleanapiapicleanapiapicsproj"
    end
    subgraph current["CleanApi.Infrastructure.csproj"]
        MAIN["<b>📦&nbsp;CleanApi.Infrastructure.csproj</b><br/><small>net8.0</small>"]
        click MAIN "#cleanapiinfrastructurecleanapiinfrastructurecsproj"
    end
    subgraph downstream["Dependencies (1"]
        P2["<b>📦&nbsp;CleanApi.Application.csproj</b><br/><small>net8.0</small>"]
        click P2 "#cleanapiapplicationcleanapiapplicationcsproj"
    end
    P1 --> MAIN
    MAIN --> P2

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 83 |  |
| ***Total APIs Analyzed*** | ***83*** |  |

