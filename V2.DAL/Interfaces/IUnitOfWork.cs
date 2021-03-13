using V2.DAL.Models;

namespace V2.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Product> Products { get; }
        IRepository<User> Users { get; }
    }
}
