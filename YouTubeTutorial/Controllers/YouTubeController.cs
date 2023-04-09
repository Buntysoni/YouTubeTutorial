using Microsoft.AspNetCore.Mvc;

namespace YouTubeTutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class YouTubeController : ControllerBase
    {
        [HttpGet("MyData")]
        public IActionResult MyData()
        {
            string name = "MyData Action!";
            return Ok(name);
        }
    }
}
