using V2.DAL.DB_Context;
using V2.DAL.Repositories;

namespace V2.DAL.InfraStructure
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ECommerceDbContext _repoContext;
        private IUserRepository _user;
        private IProductRepository _product;

        public RepositoryWrapper(ECommerceDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            }
        }
        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_repoContext);
                }
                return _product;
            }
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }

    }


    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }
        void Save();
    }
}