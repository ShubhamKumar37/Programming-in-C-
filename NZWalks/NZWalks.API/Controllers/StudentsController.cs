using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // http://localhost:5000/api/students this will be the default route for this controller
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudent()
        {
            string[] arr = {"John", "Jane", "Doe" };
            return Ok(arr);
        }
    }
}
