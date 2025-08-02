using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Action",
                    DisplayOrder = 1
                },
                new Category
                {
                    Id = 2,
                    Name = "SciFi",
                    DisplayOrder = 2
                },
                new Category
                {
                    Id = 3,
                    Name = "History",
                    DisplayOrder = 3
                },
                new Category
                {
                    Id = 4,
                    Name = "Horror",
                    DisplayOrder = 4
                }
            );
        }
    }
}
