using V2.DAL.DB_Context;
using V2.DAL.InfraStructure;
using V2.DAL.Models;

namespace V2.DAL.Repositories
{
    public class CompanyRepository : BaseRepository<Product>, ICompanyRepository
    {
        public CompanyRepository(ECommerceDbContext repositoryContext) : base(repositoryContext)
        {

        }
    }

    public interface ICompanyRepository : IBaseRepository<Product>
    {

    }
}
