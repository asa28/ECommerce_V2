using V2.DAL.Interfaces;
using V2.DAL.Models;

namespace V2.BLL.Services
{
    public class UserService
    {
        private readonly SqlRepo<User> _UserRepo;

        public UserService(SqlRepo<User> userRepo)
        {
            _UserRepo = userRepo;
        }

        public User Add()
        {
            // implement Business Logic 

            return new User();
        }
    }
}