using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.CustomActionFilter;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWalkRepository _walkRepository;
        public WalksController(IMapper mapper, IWalkRepository walkRepository)
        {
            _mapper = mapper;
            _walkRepository = walkRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWalks([FromQuery] string? filterOn, [FromQuery] string? filterQuery,
            [FromQuery] string? sortOn, [FromQuery] bool? isAsc, [FromQuery] int? page)
        {
            var walks = await _walkRepository.GetAllAsync(filterOn, filterQuery, sortOn, isAsc ?? true, page ?? 1);
            return Ok(_mapper.Map<List<WalkDto>>(walks));
        }

        [HttpPost]
        [ValidateModelAttributes]
        public async Task<IActionResult> Create([FromBody] AddWalksRequestDto addWalksRequestDto)
        {
            //if(ModelState.IsValid == false) return BadRequest(ModelState);
            var walk = _mapper.Map<Walk>(addWalksRequestDto);

            walk = await _walkRepository.CreateAsync(walk);

            return Ok(_mapper.Map<WalkDto>(walk));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            var walk = await _walkRepository.GetByIdAsync(id);
            if (walk == null) return NotFound();

            return Ok(_mapper.Map<WalkDto>(walk));
        }

        [HttpPut("{id:guid}")]
        [ValidateModelAttributes]
        public async Task<IActionResult> UpdateWalkAsync([FromRoute] Guid id, [FromBody] UpdateWalksRequestDto updateWalksRequestDto)
        {
            //if (ModelState.IsValid == false) return BadRequest(ModelState);
            var newWalk = _mapper.Map<Walk>(updateWalksRequestDto);
            newWalk = await _walkRepository.UpdateAsync(id, newWalk);

            if (newWalk == null) return NotFound();
            var completedWalk = await _walkRepository.GetByIdAsync(newWalk.Id);
            return Ok(_mapper.Map<WalkDto>(completedWalk));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteWalkAsync([FromRoute] Guid id)
        {
            var walk = await _walkRepository.DeleteAsync(id);
            if (walk == null) return NotFound();
            return Ok(_mapper.Map<WalkDto>(walk));
        }

    }
}
