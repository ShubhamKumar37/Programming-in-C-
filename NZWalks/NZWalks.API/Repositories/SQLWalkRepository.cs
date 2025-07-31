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

        public async Task<List<Walk>> GetAllAsync()
        {
            // This include is just like a populate function in SQL 
            var walks = await _context.Walks.Include("DifficultyNavigation").Include("RegionNavigation").ToListAsync();
            return walks;
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
