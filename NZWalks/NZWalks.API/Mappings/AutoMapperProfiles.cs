using AutoMapper;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
namespace NZWalks.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<Region, UpdateRegionRequestDto>().ReverseMap();
            CreateMap<Region, AddRegionRequestDto>().ReverseMap();

            CreateMap<Walk, AddWalksRequestDto>().ReverseMap();
            CreateMap<Walk, UpdateWalksRequestDto>().ReverseMap();
            CreateMap<WalkDto, UpdateWalksRequestDto>().ReverseMap();
            CreateMap<Walk, WalkDto>().ReverseMap();
            CreateMap<Difficulty, DifficultyDto>().ReverseMap();
        }
    }
}
