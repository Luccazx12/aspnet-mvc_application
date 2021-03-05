# aspnet-mvc_application
Aplicação ASP.NET MVC + Entity Framework com modelação de banco de dados

# Requisitos

## Visual Studio 2019

## Microsoft SQL Server Management Studio 18

## Entity Framework Core
--------------------

[![latest version](https://img.shields.io/nuget/v/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) [![preview version](https://img.shields.io/nuget/vpre/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/absoluteLatest) [![downloads](https://img.shields.io/nuget/dt/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)

EF Core é um mapeador de banco de dados de objetos moderno para .NET. Ele oferece suporte a consultas LINQ, controle de alterações, atualizações e migrações de esquema. EF Core funciona com SQL Server, banco de dados SQL do Azure, SQLite, banco de dados Azure Cosmos, MySQL, PostgreSQL e outros bancos de dados por meio de uma API de plug-in do provedor. 

### <strong> Instalação </strong>

EF Core está disponível em: [NuGet](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore). Instale o pacote do provedor correspondente ao seu banco de dados de destino. Olhe a [lista de provedores](https://docs.microsoft.com/ef/core/providers/) nos documentos para bancos de dados adicionais.

```sh
Install-Package EntityFramework
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Cosmos
```

Use a opção `--version` para especificar a [versão preview](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/absoluteLatest) para instalar.
