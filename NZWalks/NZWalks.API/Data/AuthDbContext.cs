using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace NZWalks.API.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var readOnlyId = "bd128958-2fd8-4e64-972f-f8ddf39a9f6c";
            var writeOnlyId = "5dafffa9-1486-474c-9155-1d6b361d76c9";

            var roles = new List<IdentityRole> { 
                new IdentityRole
                {
                    Id = readOnlyId,
                    ConcurrencyStamp = readOnlyId,
                    Name = "ReadOnly",
                    NormalizedName = "READONLY"
                },
                new IdentityRole
                {
                    Id = writeOnlyId,
                    ConcurrencyStamp = writeOnlyId,
                    Name = "WriteOnly",
                    NormalizedName = "WRITEONLY"
                }
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
