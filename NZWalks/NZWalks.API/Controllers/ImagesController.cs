using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> UploadImage([FromForm] ImageUploadReqDto request)
        {
            ValidateImage(request);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var imageDomainModel = new Image
            {
                File = request.File,
                FileName = request.FileName,
                FileExtension = Path.GetExtension(request.FileName),
                FileSizeInByte = request.File.Length,
                FileDescription = request.FileDescription,
            };

            await imageRepository.UploadImageAsync(imageDomainModel);
            return Ok(imageDomainModel);
        }

        private void ValidateImage(ImageUploadReqDto request)
        {
            var acceptedExtension = new string[] { ".png", ".jpeg", ".jpg" };
            if(acceptedExtension.Contains(Path.GetExtension(request.File.FileName)) == false)
            {
                ModelState.AddModelError("File", "Unsupported files extension");
            }

            if(request.File.Length > 10485760)
            {
                ModelState.AddModelError("File", "File size is bigger then 10MB");
            }
        }
    }
}
