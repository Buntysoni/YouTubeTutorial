using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YouTubeTutorial.BLL.Interface;
using YouTubeTutorial.Data.context;

namespace YouTubeTutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IUsersRepository _usersRepository;
        public HomeController(ApplicationDbContext context, IUsersRepository usersRepository)
        {
            _context = context;
            _usersRepository = usersRepository;
        }

        [HttpGet("UsersCount")]
        public IActionResult UsersCount()
        {
            var usersCount = _usersRepository.GetTotalUsersCount();
            return Ok(usersCount);
        }

        [HttpGet("GetData")]
        public IActionResult GetData()
        {
            var studentJoinData = _context.tbl_student.Include(x=>x.tbl_subject).ToList();

            var studentJoinDataTwo = _context.tbl_student.Join(_context.tbl_subject, st => st.subjectid, sb => sb.subjectid,
                (st, sb) => new
                {
                    st.studentid,
                    st.name,
                    sb.subjectname
                }).ToList();

            return Ok(studentJoinDataTwo);
        }

        [HttpPost("SaveDataQueryString")]
        public IActionResult SaveDataQueryString(string firstname, string lastname)
        {
            return Ok(firstname + lastname);
        }

        [HttpPost("SaveData")]
        public IActionResult SaveData(SaveDataModel model)
        {
            return Ok(model);
        }

        [HttpPost("GetUsers")]
        public IActionResult GetUsers(Users model)
        {
            var users = _usersRepository.GetUsersList(model);
            return Ok(users);
        }

        [HttpPost("SaveUser")]
        public IActionResult SaveUser(Users model)
        {
            var users = _usersRepository.SaveUser(model);
            return Ok(users);
        }

        [HttpPost("SaveUsersList")]
        public IActionResult SaveUsersList(List<Users> model)
        {
            var users = _usersRepository.SaveUsersList(model);
            return Ok(users);
        }

        [HttpPost("UpdateUser")]
        public IActionResult UpdateUser(Users model)
        {
            var users = _usersRepository.UpdateUser(model);
            return Ok(users);
        }

        [HttpPost("UpdateUserSecond")]
        public IActionResult UpdateUserSecond(Users model)
        {
            var users = _usersRepository.UpdateUserSecond(model);
            return Ok(users);
        }

        [HttpPost("DeleteUser")]
        public IActionResult DeleteUser(Users model)
        {
            var users = _usersRepository.DeleteUser(model);
            return Ok(users);
        }

        [HttpPost("DeleteByRange")]
        public IActionResult DeleteByRange(List<Users> model)
        {
            var users = _usersRepository.DeleteByRange(model);
            return Ok(users);
        }

        [HttpPost("GetStudentsList")]
        public IActionResult GetStudentsList()
        {
            var users = _usersRepository.GetStudentsList();
            return Ok(users);
        }

        #region test model
        public class SaveDataModel
        {
            public int id { get; set; }
            public string? Name { get; set; }
            public string? Class { get; set; }
        }
        #endregion
    }
}
