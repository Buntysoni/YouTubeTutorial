using YouTubeTutorial.Data.Models;

namespace YouTubeTutorial.BLL.Services
{
    public interface ITokenService
    {
        string GenerateToken(LoginModel model);
    }
}