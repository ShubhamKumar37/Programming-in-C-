using Microsoft.AspNetCore.Hosting;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class LocalImageRepository : IImageRepository
    {
        // This class is intended to handle local image storage operations.
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LocalImageRepository(IWebHostEnvironment webHostEnviroment, AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _webHostEnvironment = webHostEnviroment;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Image> UploadImageAsync(Image image)
        {
            var localPath = Path.Combine(_webHostEnvironment.WebRootPath, "images", $"{image.FileName}{ image.FileExtension}");
            using var stream = new FileStream(localPath, FileMode.Create);
            await image.File.CopyToAsync(stream);

            var urlFilePath = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}{_httpContextAccessor.HttpContext.Request.PathBase}/images/{image.FileName}.{image.FileExtension}";

            image.FilePath = urlFilePath; 
            await _context.Images.AddAsync(image);
            await _context.SaveChangesAsync();
            return image;
        }
    } 
}
