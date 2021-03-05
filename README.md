# aspnet-mvc_application
Aplicação ASP.NET MVC + Entity Framework com modelação de Banco de Dados

# Requisitos
--------------------


## Ambientes de Desenvolvimento e Referências 

* IDE:    **VS2019**
* .NET FrameWork Version: **4.7.2**
* MVC Version: **5.2.7**
* ORM: **Entity Framework 6.0**
* DB:     **SQLSERVER19 - SSMS18.8**



## Entity Framework Core

[![latest version](https://img.shields.io/nuget/v/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) [![preview version](https://img.shields.io/nuget/vpre/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/absoluteLatest) [![downloads](https://img.shields.io/nuget/dt/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)

EF Core é um mapeador de banco de dados de objetos moderno para .NET. Ele oferece suporte a consultas LINQ, controle de alterações, atualizações e migrações de esquema. EF Core funciona com SQL Server, banco de dados SQL do Azure, SQLite, banco de dados Azure Cosmos, MySQL, PostgreSQL e outros bancos de dados por meio de uma API de plug-in do provedor. 

### <strong> Instalação </strong>

EF Core está disponível em: [NuGet](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore). Instale o pacote do provedor correspondente ao seu banco de dados de destino. Olhe a [lista de provedores](https://docs.microsoft.com/ef/core/providers/) nos documentos para bancos de dados adicionais.

```sh
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Cosmos
```

Use a opção `--version` para especificar a [versão preview](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/absoluteLatest) para instalar.

# Como Usar o Projeto ASP.NET MVC 

1 - Baixe o repositório.
2 - Dentro do seu projeto no Visual Studio, insira o seguinte código no *Package Manager Console*:

```sh
Install-Package EntityFramework
```

3 - Faça as seguintes mudanças no arquivo Web.Config:

```sh
<add name="**(Como será referênciada no seu código essa conexão)**" connectionString="Data Source=**(NOME-DO-SEU-PC)**; Language=Brazilian; Initial Catalog=**(Nome do Banco de dados que será criado)**; Integrated Security=True" providerName="System.Data.SqlClient" />
```
(Recomendo deixar o name como está **(name="TFConnectionString")**, para evitar mais mudanças no código e no TFContext, mas fica a seu critério.

4 - Ajuste o código, inserindo suas Models, Controllers e Views como desejar.

**[Adicionando uma Model  - ASP.NET MVC (Microsoft)](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-5.0&tabs=visual-studio)**

**[Adicionando um Controller  - ASP.NET MVC (Microsoft)](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-5.0&tabs=visual-studio)**

**[Adicionando uma View   - ASP.NET MVC (Microsoft)](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-5.0&tabs=visual-studio)**



5 - Execute os seguintes comandos para criar seu Banco de Dados:

```sh
Enable-Migrations

Add-Migration (NOME QUE DESEJAR, PRIMEIRO RELEASE PRO SEU BANCO DE DADOS)

update-database
```
Pronto! Agora será criada uma *DataBase* no seu Servidor de Banco de Dados pelo nome definido no **Initial Catalog (Passo 3)**.
