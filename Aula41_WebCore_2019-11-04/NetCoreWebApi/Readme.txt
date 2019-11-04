ASP.NET Core API w/ Entity Framework.
New Project > ASP NET Core WebApp > API (uncheck HTTPS)
Create Model folder
Nuget (install)> 
	Microsoft.EntityFrameworkCore.SqlServer
	Microsoft.EntityFrameworkCore.InMemory
In Model folder > Add > Class > FilneNameContext
	: DbContext 

	public WebApiContext(DbContextOptions<WebApiContext> options)
            : base (options)
        {

        }

	public DbSet<Model> Models {get;set;}

Dependencies in Startup.cs
	Add using:
		using Microsoft.EntityFrameworkCore;
		using NetCoreWebApi.Model;	
	Add service into ConfigureServices
		services.AddDbContext<WebApiContext>(options => options.UseInMemoryDatabase("DBConnect"));

On Controllers > Add > New Scaffolding item > API Controller w/ actions, using EF
		Select ModelClass and Context > Add

Config initial startup:
	profiles
		launchUrl: "Api/NameModel"

