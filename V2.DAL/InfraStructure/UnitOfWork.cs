using System;
using V2.DAL.DB_Context;
using V2.DAL.Repositories;

namespace V2.DAL.InfraStructure
{
    public  class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerceDbContext _context;

        public UnitOfWork(ECommerceDbContext context)
        {
            _context = context;
        }

        public IUserRepository Users { get; }
        public IProductRepository Products { get; }
        public ICompanyRepository Companies { get; }
        public ICategoryRepository Categories { get; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }


    public interface IUnitOfWork : IDisposable
    { 
        IUserRepository Users { get;}
        IProductRepository Products { get; }
        ICompanyRepository Companies { get; }
        ICategoryRepository Categories { get; }

        int Save();
    }
}
