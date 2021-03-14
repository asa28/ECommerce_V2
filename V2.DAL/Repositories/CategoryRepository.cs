using V2.DAL.DB_Context;
using V2.DAL.InfraStructure;
using V2.DAL.Models;

namespace V2.DAL.Repositories
{


    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ECommerceDbContext repositoryContext) : base(repositoryContext)
        {

        }
    }

    public interface ICategoryRepository : IBaseRepository<Category>
    {

    }

}
