using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BlazorApp.Models
{
	public class AplicationDbContextFactory : IDesignTimeDbContextFactory<AplicationDbContext>
	{
		public AplicationDbContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var connectionString = configuration.GetConnectionString("AplicationDb");

			var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
			optionsBuilder.UseSqlServer(connectionString);

			return new AplicationDbContext(optionsBuilder.Options);
		}
	}
}
