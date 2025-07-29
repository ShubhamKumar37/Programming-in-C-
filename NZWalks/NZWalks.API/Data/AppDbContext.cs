using Microsoft.EntityFrameworkCore;

namespace NZWalks.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Models.Domain.Region> Regions { get; set; }
        public DbSet<Models.Domain.Walk> Walks { get; set; } 
        public DbSet<Models.Domain.Difficulty> WalkDifficulties { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
