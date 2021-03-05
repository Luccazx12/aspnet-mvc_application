# aspnet-mvc_application
Aplicação ASP.NET MVC + Entity Framework com modelação de banco de dados

## Requisitos


## Entity Framework Core
--------------------

[![latest version](https://img.shields.io/nuget/v/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) [![preview version](https://img.shields.io/nuget/vpre/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/absoluteLatest) [![downloads](https://img.shields.io/nuget/dt/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)

EF Core is a modern object-database mapper for .NET. It supports LINQ queries, change tracking, updates, and schema migrations. EF Core works with SQL Server, Azure SQL Database, SQLite, Azure Cosmos DB, MySQL, PostgreSQL, and other databases through a provider plugin API.

### Installation

EF Core is available on [NuGet](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore). Install the provider package corresponding to your target database. See the [list of providers](https://docs.microsoft.com/ef/core/providers/) in the docs for additional databases.

```sh
Install-Package EntityFramework
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Cosmos
```

Use the `--version` option to specify a [preview version](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/absoluteLatest) to install.
