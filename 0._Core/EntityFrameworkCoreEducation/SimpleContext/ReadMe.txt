cd D:\Source\Repos\Education\Education\EntityFrameworkCoreEducation\


******* .net core CLI **********
dotnet ef migrations add InitialSimpleContext                   ********** Create migration command, ready for execute
dotnet ef database update										********** Command database update to execute commad

dotnet ef migrations add InitialSimpleContext --context DbSimpleContext --output-dir Migrations\SimpleContextMigrations
dotnet ef database update --connection "Server=ADMIN;Database=Education;User ID=TRANTIN;Password=genius;TrustServerCertificate=True"




3 type loading in ef core:
	- Edge Loading: Load all data and ref data - 1 time go to db. Using: Include(), ThenInclude()		(Default)
	- Lazy Loading: Load data has been call, not load data ref, data ref will be loaded when user specifically request it - many time depend user. Using: ef.Proxy,ef.Astract
	- Explicit Loading: Is Lazy Loading, but we must call load() method to load data ref