using System.Collections.Generic;
using System.Linq;
using V2.DAL.DB_Context;
using V2.DAL.InfraStructure;
using V2.DAL.Models;

namespace V2.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ECommerceDbContext _Context;
        public UserRepository(ECommerceDbContext Context) : base(Context)
        {
            _Context = Context;
        }

        public IEnumerable<User> FindAll(int amount)
        {
            return _Context.Users.OrderByDescending(a => a.Id).Take(amount).ToList();
        }
    }

    public interface IUserRepository: IBaseRepository<User>
    {

    }
}
