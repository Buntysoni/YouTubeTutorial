using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using YouTubeTutorial.Data.Models;

namespace YouTubeTutorial.BLL.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private SymmetricSecurityKey _key;
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is my most powerfull secret key and security key for my project"));
        }

        public string GenerateToken(LoginModel model)
        {
            var claims = new List<Claim>
            {
                new Claim("email",model.Email),
                new Claim("loginTime",DateTime.Now.ToString())
            };
            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = creds,
                Expires = DateTime.Now.AddMinutes(10),
                Issuer = "abc",
                Audience = "abc"
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            string my_Token = tokenHandler.WriteToken(token);
            return my_Token;
        }
    }
}
