using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarProject //DO NOT Change the namespace name
{
    public class CarContext : DbContext // Inherit from DbContext
    {
        public DbSet<Car> Cars { get; set; } // Declare Cars of type DbSet

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); // Configure the database connection
        }
    }
} 