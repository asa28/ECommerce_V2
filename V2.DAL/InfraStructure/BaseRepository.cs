using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using V2.DAL.DB_Context;

namespace V2.DAL.InfraStructure
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {       
        protected ECommerceDbContext RepositoryContext { get; set; }
        public BaseRepository(ECommerceDbContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }
        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }
        public void FindById(int Id) 
        {
            this.RepositoryContext.Set<T>().Find(Id);
        }
        public IEnumerable<T> GetAllEntities() 
        {
            return this.RepositoryContext.Set<T>().OrderByDescending(T => T.CreatedDate).ToList();
        }
        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

    }

    public interface IBaseRepository<T> where T : BaseEntity
    {
       IQueryable<T> FindAll();
       IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
       void FindById(int Id);
       IEnumerable<T> GetAllEntities();
       void Create(T entity);
       void Update(T entity);
       void Delete(T entity);
    }
}