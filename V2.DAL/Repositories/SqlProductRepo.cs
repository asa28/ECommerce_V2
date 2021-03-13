using System;
using System.Collections.Generic;
using System.Linq;
using V2.DAL.DB_Context;
using V2.DAL.Interfaces;
using V2.DAL.Models;

namespace V2.DAL.Repositories
{
    public class SqlProductRepo : IRepository<Product>
    {
        private readonly ECommerceDbContext _dbContext;

        public SqlProductRepo(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Add(Product p)
        {
            throw new NotImplementedException();
        }

        public void Edit(Product p)
        {
            var product = _dbContext.Products.FirstOrDefault(d => d.Id == p.Id);
        }

        public Product FindById(int Id)
        {
            return _dbContext.Products.FirstOrDefault(d => d.Id == Id);
            // return _dbContext.Products.Find(Id);
        }

        public IEnumerable<Product> GetAllEntities()
        {
            return _dbContext.Products.ToList();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
