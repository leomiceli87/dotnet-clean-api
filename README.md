# CleanApi — .NET 8 REST API with Clean Architecture

A production-ready Web API built with .NET 8 following Clean Architecture principles, demonstrating separation of concerns, SOLID principles, and best practices for enterprise .NET development.

## Architecture

The solution is organized into 4 layers:
CleanApi.Domain → Entities, business rules, domain invariants
CleanApi.Application → Use cases, interfaces, DTOs
CleanApi.Infrastructure → EF Core, SQLite, repository implementations
CleanApi.API → Controllers, middleware, dependency injection

Dependencies always point inward — the Domain knows nothing about EF Core, HTTP, or any external framework.

## Tech Stack

- **.NET 8** (LTS)
- **ASP.NET Core Web API**
- **Entity Framework Core 8** with SQLite
- **Clean Architecture** with Domain-Driven Design patterns
- **Swagger / OpenAPI** for API documentation
- **Factory Method pattern** for domain entity creation
- **Repository pattern** with interface segregation

## Key Design Decisions

**Domain entities use private constructors** — a `Product` can only be created via `Product.Create()`, ensuring business rules (non-empty name, positive price) are always enforced at the domain level.

**Repository interface lives in Application, not Infrastructure** — the use cases depend on the abstraction, not the implementation. Swapping SQLite for SQL Server requires zero changes outside the Infrastructure layer.

## Getting Started

```bash
git clone https://github.com/leomiceli87/dotnet-clean-api.git
cd dotnet-clean-api/CleanApi.API
dotnet run
```

Navigate to `http://localhost:5276/swagger` to explore the API.

## Endpoints

| Method | Endpoint           | Description          |
| ------ | ------------------ | -------------------- |
| GET    | /api/products      | List all products    |
| GET    | /api/products/{id} | Get product by ID    |
| POST   | /api/products      | Create a new product |
| DELETE | /api/products/{id} | Delete a product     |

## Author

Leonardo Miceli — Senior .NET Software Engineer  
[LinkedIn](https://www.linkedin.com/in/leonardo-miceli-7564a989/) · [GitHub](https://github.com/leomiceli87)
