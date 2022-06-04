# RetseptiPank

## Tooling
~~~~shell
dotnet tool update -g dotnet-ef
dotnet tool update -g dotnet-aspnet-codegenerator
dotnet tool list -g
dotnet --info
~~~~
## Database
~~~~shell
dotnet ef migrations add --project App.DAL.EF --startup-project WebApp --context AppDbContext Initial

dotnet ef migrations remove --project App.DAL.EF --startup-project WebApp --context AppDbContext 

dotnet ef database update --project App.DAL.EF --startup-project WebApp

dotnet ef database drop --project App.DAL.EF --startup-project WebApp
~~~~

## Scaffolding
### Controllers
~~~~shell
~~~~
---