
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
namespace NZWalks.API.Repositories;

public class SQLRegionRepository : IRegionRepository
{
    private readonly AppDbContext _context;
    public SQLRegionRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<Region>> GetAllAsync()
    {
        var regions = await _context.Regions.ToListAsync();
        return regions;
    }

    public async Task<Region?> GetByIdAsync(Guid id)
    {
        return await _context.Regions.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Region> CreateAsync(Region region)
    {
        await _context.Regions.AddAsync(region);
        await _context.SaveChangesAsync();
        return region;
    }

    public async Task<Region?> UpdateAsync(Guid id, Region region)
    {
        var existingRegion = await _context.Regions.FirstOrDefaultAsync(x => x.Id == id);
        if (existingRegion == null)
        {
            return null; // Region not found
        }
        existingRegion.Code = region.Code;
        existingRegion.Name = region.Name;
        existingRegion.RegionImageUrl = region.RegionImageUrl;
        await _context.SaveChangesAsync();
        return existingRegion;
    }

    public async Task<Region?> DeleteAsync(Guid id)
    {
        var region = await _context.Regions.FirstOrDefaultAsync(x => x.Id == id);
        if (region == null) return null; 
        _context.Regions.Remove(region);
        await _context.SaveChangesAsync();
        return region;
    }
}