using V2.DAL.DB_Context;
using V2.DAL.InfraStructure;
using V2.DAL.Models;

namespace V2.DAL.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceDbContext repositoryContext) : base(repositoryContext)
        {

        }
    }

    public interface IProductRepository : IBaseRepository<Product>
    {

    }


}
