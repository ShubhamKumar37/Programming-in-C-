//using NZWalks.API.Models.Domain;

//namespace NZWalks.API.Repositories
//{
//    public class InMemoryRegionRepository : IRegionRepository // Now i can use this class to simulate data retrieval without a database so its just an abstract layer between controller and data source
//    {
//        public async Task<List<Region>> GetAllAsync()
//        {
//            // Simulating data retrieval from an in-memory collection
//            var regions = new List<Region>
//            {
//                new Region
//                {
//                    Id = Guid.NewGuid(),
//                    Code = "NI",
//                    Name = "North Island",
//                    RegionImageUrl = "https://example.com/north-island.jpg"
//                },
//                new Region
//                {
//                    Id = Guid.NewGuid(),
//                    Code = "SI",
//                    Name = "South Island",
//                    RegionImageUrl = "https://example.com/south-island.jpg"
//                },
//                new Region
//                {
//                    Id = Guid.NewGuid(),
//                    Code = "CI",
//                    Name = "Central Island",
//                    RegionImageUrl = "https://example.com/central-island.jpg"
//                }
//            };
//            return regions;
//        }
//    }
//}
