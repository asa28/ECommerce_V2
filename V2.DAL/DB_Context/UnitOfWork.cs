using V2.DAL.Interfaces;
using V2.DAL.Models;

namespace V2.DAL.DB_Context
{
    public class UnitOfWork 
    {
        private ECommerceDbContext _dbContext;
        private SqlRepo<Product> _Products;
        private SqlRepo<User> _Users;

        public UnitOfWork(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public SqlRepo<Product> Products
        {
            get
            {
                if (_Products == null)
                {
                    _Products = new SqlRepo<Product>();
                }

                return _Products;
            }
        }

        public SqlRepo<User> Users
        {
            get
            {

                if (_Users == null)
                {
                    _Users = new SqlRepo<User>();
                }

                return _Users;
            }
        }



        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
