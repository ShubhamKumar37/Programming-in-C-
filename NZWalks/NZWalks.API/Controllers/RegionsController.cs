using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    [Route("api/reg")] // This mean the domain will be http://localhost:5000/api/reg
    [ApiController]
    public class RegionsController : ControllerBase
    {

        private readonly AppDbContext _context;

        public RegionsController(AppDbContext context) { _context = context; }

        [HttpGet] // This means the method will respond to GET requests
        public IActionResult GetAllRegions()
        {
            var regions = _context.Regions.ToList(); // Fetch all regions from the database
            //var regions = new List<Region>
            //{
            //    new Region{
            //        Id = Guid.NewGuid(),
            //        Code = "NI",
            //        Name = "North Island",
            //        RegionImageUrl = "https://example.com/north-island.jpg"
            //    },
            //    new Region{
            //        Id = Guid.NewGuid(),
            //        Code = "SI",
            //        Name = "South Island",
            //        RegionImageUrl = "https://example.com/south-island.jpg"
            //    },
            //    new Region
            //    {
            //        Id = Guid.NewGuid(),
            //        Code = "CI",
            //        Name = "Central Island",
            //        RegionImageUrl = "https://example.com/central-island.jpg"
            //    }
            //};
            return Ok(regions); // Return the regions with a 200 OK status
        }
    }
}
