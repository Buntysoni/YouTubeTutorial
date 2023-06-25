using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using YouTubeTutorial.BLL.Services;
using YouTubeTutorial.Data.context;
using YouTubeTutorial.Data.Models;

namespace YouTubeTutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class YouTubeController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        private readonly ITokenService _tokenService;
        public YouTubeController(IWebHostEnvironment webHostEnvironment, IConfiguration configuration, ApplicationDbContext context, ITokenService tokenService)
        {
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
            _context = context;
            _tokenService = tokenService;

        }

        [Authorize]
        [HttpGet("MyData")]
        public IActionResult MyData()
        {
            string name = "MyData Action!";
            return Ok(name);
        }

        [HttpPost("FileUpload")]
        public IActionResult FileUpload([FromForm] IFormFile formFile)
        {
            var fileInfo = UNLEIN.Utilities.FileSystem.FileInfo(formFile);
            string fileNewName = DateTime.Now.ToString("yyyyMMddhhmmssffff") + fileInfo.FileName;
            string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/");
            string uploadPath = Path.Combine(uploadFolder, fileNewName);
            using(var fileSteam = new FileStream(uploadPath, FileMode.Create))
            {
                formFile.CopyTo(fileSteam);
            }
            string returnPath = "Uploads/" + fileNewName;
            return Ok(returnPath);
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginModel model)
        {
            string token = string.Empty;
            var userData = _context.Users.Where(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefault();
            if(userData != null)
            {
                //generate token
                token = _tokenService.GenerateToken(model);
            }
            return Ok(new { token = token });
        }

        //[HttpPost("FileUpload")]
        //public IActionResult FileUpload([FromForm]IFormFile model)
        //{
        //    var file = UNLEIN.Utilities.FileSystem.FileInfo(model);
        //    string fileName = DateTime.Now.ToString("yyyyMMddhhmmssffff") + file.FileName;
        //    string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/");
        //    string filePath = Path.Combine(uploadFolder, fileName);
        //    string pathInfo = "Uploads/" + fileName;
        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        model.CopyTo(stream);
        //    }
        //    var result = pathInfo;
        //    return Ok(result);
        //}
    }
}
