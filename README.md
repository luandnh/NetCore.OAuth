# **NetCore.OAuth**
> OAuth2.0 Web API
- SDK: .NET Core 3.1
- Framework: Web API
- Database: MySQL

#### EF Core Tool:
- Install: `dotnet tool install --global dotnet-ef`


## OAuthDBContext
This is library to create identity database.
### Requirement:
#### Package:
- Microsoft.AspNetCore.Identity
- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Relational
- MySql.Data.EntityFrameworkCore

#### EF Core Command:
- Add Migration : `dotnet ef migrations add InitialCreate`
- Update Database: `dotnet ef database update`

## OAuthService
This is service library base on repository pattern.
- Models + ViewModel + Request/Response Model
- Repository
- Service

#### Package:
- AutoMapper
- Newtonsoft.Json

#### EF Core Command:
- Scaffold DB: `dotnet ef dbcontext scaffold "server=localhost;port=3306;user=dbadmin;password=123456;database=db_oauth" MySql.Data.EntityFrameworkCore -o Models -f`
