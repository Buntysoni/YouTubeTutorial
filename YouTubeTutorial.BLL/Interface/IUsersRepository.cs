using YouTubeTutorial.Data.context;
using YouTubeTutorial.Data.Models;

namespace YouTubeTutorial.BLL.Interface
{
    public interface IUsersRepository
    {
        List<Users> GetUsersList(Users model);
        List<StudentDataModel> GetStudentsList();
        int GetTotalUsersCount();
        int SaveUser(Users model);
        int SaveUsersList(List<Users> model);
        int UpdateUser(Users model);
        string UpdateUserSecond(Users model);
        int DeleteUser(Users model);
        int DeleteByRange(List<Users> model);
    }
}
