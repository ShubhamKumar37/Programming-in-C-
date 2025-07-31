using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZWalks.API.CustomActionFilter;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;


namespace NZWalks.API.Controllers
{
    [Route("api/reg")] // This mean the domain will be http://localhost:5000/api/reg
    [ApiController]
    
    public class RegionsController : ControllerBase
    {

        private readonly AppDbContext _context;
        private readonly IRegionRepository regionRepository;
        private readonly IMapper _mapper;
        public RegionsController(AppDbContext context, IRegionRepository regionRepository, IMapper mapper) { 
            _context = context;
            this.regionRepository = regionRepository;
            _mapper = mapper;
        }

        [HttpGet] // This means the method will respond to GET requests
        public async Task<IActionResult> GetAllRegions()
        {
            //var regions = await _context.Regions.ToListAsync();
            var regions = await regionRepository.GetAllAsync();
            Console.WriteLine("Regions fetched successfully so check it");
            return Ok(_mapper.Map<List<RegionDto>>(regions)); // Return the regions with a 200 OK status

            //var result = new List<RegionDto>();
            //foreach (var i in regions)
            //{
            //    result.Add(new RegionDto()
            //    {
            //        Id = i.Id,
            //        Code = i.Code,
            //        Name = i.Name,
            //        RegionImageUrl = i.RegionImageUrl
            //    });
            //}
        }

        [HttpGet]
        [Route("{id:guid}")] // This means the method will respond to GET requests with a specific region ID
        [Authorize]
        public async Task<IActionResult> GetRegionById([FromRoute] Guid id) // By FromRoute it will get the ID from the URL
        {
            // var regionId = _context.Regions.Find(id); // Find is only applicable for primary keys so we use LINQ
            var regionId = await regionRepository.GetByIdAsync(id);
            if (regionId == null) return NotFound("Region not found");
            return Ok(_mapper.Map<RegionDto>(regionId));
        }

        [HttpPost]
        [ValidateModelAttributes]
        public async Task<IActionResult> CreateRegion([FromBody] AddRegionRequestDto addRegionRequestDto)
        {
            //if(ModelState.IsValid == false) return BadRequest(ModelState); // Check if the model state is valid

            var newRegion = _mapper.Map<Region>(addRegionRequestDto);

            newRegion = await regionRepository.CreateAsync(newRegion); // Using the repository to create a new region
            await _context.SaveChangesAsync();

            var result = _mapper.Map<RegionDto>(newRegion);

            return CreatedAtAction(nameof(GetRegionById), new { id = result.Id }, result);
        }

        [HttpPut]
        [Route("{id:guid}")] // Here i have to provide all the values to update the region even if I want to update only one value
        [ValidateModelAttributes]
        public async Task<IActionResult> UpdateRegion([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {
            //if(ModelState.IsValid == false) return BadRequest(ModelState); // Check if the model state is valid
            var regionExist = await regionRepository.UpdateAsync(id, _mapper.Map<Region>(updateRegionRequestDto));

            var result = _mapper.Map<RegionDto>(regionExist);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:guid}")] // This means the method will respond to DELETE requests with a specific region ID'
        public async Task<IActionResult> DeleteRegion([FromRoute] Guid id)
        {
            var result = await regionRepository.DeleteAsync(id);
            if (result == null) return NotFound("Region not found");

            return Ok("Region deleted successfully");
        }
    }
}
