using V2.DAL.Models;
using V2.DAL.Repositories;

namespace V2.BLL.Services
{
    public class UserService
    {
        private readonly UserRepository _UserRepo;

        public UserService(UserRepository userRepo)
        {
            _UserRepo = userRepo;
        }

        // implement Business Logic 

        public User Add()
        {
            return new User();
        }
    }
}