using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Repositories
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly AppDbContext _context;
        public SQLWalkRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Walk> CreateAsync(Walk walk)
        {

            await _context.Walks.AddAsync(walk);
            await _context.SaveChangesAsync();
            var newWalk = await _context.Walks.Include("DifficultyNavigation").Include("RegionNavigation").FirstOrDefaultAsync(x => x.Id == walk.Id);
            return newWalk;
        }

        public async Task<List<Walk>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortOn = null, bool isAsc = true, int page = 1)
        {
            // This include is just like a populate function in SQL 
            //var walks = await _context.Walks.Include("DifficultyNavigation").Include("RegionNavigation").ToListAsync();
            var walks = _context.Walks.Include("DifficultyNavigation").Include("RegionNavigation").AsQueryable();

            if(string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                if(filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                    walks = walks.Where(x => x.Name.Contains(filterQuery));
            }

            if(string.IsNullOrWhiteSpace(sortOn) == false)
            {
                if(sortOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                    walks = (bool)isAsc ? walks.OrderBy(x => x.Name) : walks.OrderByDescending(x => x.Name);
                
                else if(sortOn.Equals("LengthInKm", StringComparison.OrdinalIgnoreCase))
                    walks = (bool)isAsc ? walks.OrderBy(x => x.LengthInKm) : walks.OrderByDescending(x => x.LengthInKm);
            }

            int skip = (page - 1) * 3; // Assuming page size is 10
            return await walks.Skip(skip).Take(3).ToListAsync();
        }

        public async Task<Walk?> GetByIdAsync(Guid id)
        {
            var walk = await _context.Walks.Include("DifficultyNavigation").Include("RegionNavigation").FirstOrDefaultAsync(x => x.Id == id);
            return walk;
        }

        public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
        {
            var walkExist = await _context.Walks.FirstOrDefaultAsync(x => x.Id == id);
            if(walkExist == null) return null; 

            walkExist.Name = walk.Name;
            walkExist.LengthInKm = walk.LengthInKm;
            walkExist.WalkImageUrl = walk.WalkImageUrl;
            walkExist.RegionId = walk.RegionId;
            walkExist.DifficultyId = walk.DifficultyId;
            walkExist.Description = walk.Description;
            await _context.SaveChangesAsync();
            
            return walkExist;
        }

        public async Task<Walk?> DeleteAsync(Guid id)
        {
            var walkExist = await _context.Walks.FirstOrDefaultAsync(x => x.Id == id);
            if (walkExist == null) return null;
            _context.Walks.Remove(walkExist);

            await _context.SaveChangesAsync();
            return walkExist;
        }


    }
}
