using System.Globalization;
using System.Linq.Expressions;
using YouTubeTutorial.BLL.Interface;
using YouTubeTutorial.Data.context;
using YouTubeTutorial.Data.Models;

namespace YouTubeTutorial.BLL.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationDbContext _context;
        public UsersRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Users> GetUsersList(Users model)
        {
            List<Users> users = new List<Users>();
            try
            {
                string searchText = model.Search;

                Expression<Func<Users, object>> orderBy = x => x.id;
                if (model.SortBy == "id")
                {
                    orderBy = x => x.id;
                }
                else if (model.SortBy == "Name")
                {
                    orderBy = x => x.Name;
                }
                else if (model.SortBy == "Email")
                {
                    orderBy = x => x.Email;
                }
                else if (model.SortBy == "Phone")
                {
                    orderBy = x => x.Phone;
                }

                var a = (model.PageIndex - 1) * model.PageSize;

                if (model.SortOrder != null)
                {
                    if (model.SortOrder.ToLower() == "asc")
                    {
                        users = _context.Users.Where(x => x.Name.Contains(searchText != null ? searchText : x.Name))
                        .OrderBy(orderBy).Skip((model.PageIndex - 1) * model.PageSize).Take(model.PageSize).ToList();
                    }
                    else if (model.SortOrder.ToLower() == "desc")
                    {
                        users = _context.Users.Where(x => x.Name.Contains(searchText != null ? searchText : x.Name))
                        .OrderByDescending(orderBy).Skip((model.PageIndex - 1) * model.PageSize).Take(model.PageSize).ToList();
                    }
                }
                else
                {
                    users = _context.Users.Where(x => x.Name.Contains(searchText != null ? searchText : x.Name))
                        .OrderByDescending(orderBy).Skip((model.PageIndex - 1) * model.PageSize).Take(model.PageSize).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return users;
        }

        public List<StudentDataModel> GetStudentsList()
        {
            List<StudentDataModel> StudentsList = new List<StudentDataModel>();
            try
            {
                StudentsList = (from s in _context.student
                                join a in _context.addresses
                                on s.id equals a.studentid
                                join v in _context.vehicle
                                on a.id equals v.addressid
                                select new StudentDataModel
                                {
                                    id = s.id,
                                    name = s.name,
                                    mobile = s.mobile,
                                    address = a.address,
                                    vehiclenumber = v.vehiclenumber
                                }).ToList();
            }
            catch (Exception ex)
            {

            }
            return StudentsList;
        }

        public int GetTotalUsersCount()
        {
            return _context.Users.ToList().Count;
        }

        public int SaveUser(Users model)
        {
            int IsSave = 0;
            try
            {
                _context.Add(model);
                if (_context.SaveChanges() > 0)
                {
                    IsSave++;
                }
            }
            catch (Exception ex)
            {

            }
            return IsSave;
        }

        public int SaveUsersList(List<Users> model)
        {
            int SaveId = 0;
            try
            {
                foreach (var item in model)
                {
                    _context.Add(item);
                }
                if (_context.SaveChanges() > 0)
                {
                    SaveId++;
                }
            }
            catch (Exception ex)
            {

            }
            return SaveId;
        }

        public int UpdateUser(Users model)
        {
            int UpdateId = 0;
            try
            {
                _context.Update(model);
                if (_context.SaveChanges() > 0)
                {
                    UpdateId++;
                }
            }
            catch (Exception ex)
            {

            }
            return UpdateId;
        }

        public string UpdateUserSecond(Users model)
        {
            string updateMessage = string.Empty;
            try
            {
                var oldData = _context.Users.Where(x => x.id == model.id).FirstOrDefault();
                if (oldData != null)
                {
                    oldData.Email = model.Email;
                    if (_context.SaveChanges() > 0)
                    {
                        updateMessage = "Data Update Successfully!";
                    }
                }
                else
                {
                    updateMessage = "No Data Found";
                }
            }
            catch (Exception ex)
            {

            }
            return updateMessage;
        }

        public int DeleteUser(Users model)
        {
            int deleteId = 0;
            try
            {
                _context.Remove(model);
                if (_context.SaveChanges() > 0)
                {

                }
            }
            catch (Exception ex)
            {

            }
            return deleteId;
        }

        public int DeleteByRange(List<Users> model)
        {
            int deleteId = 0;
            try
            {
                _context.RemoveRange(model);
                if (_context.SaveChanges() > 0)
                {
                    deleteId++;
                }
            }
            catch (Exception ex)
            {

            }
            return deleteId;
        }
    }
}
