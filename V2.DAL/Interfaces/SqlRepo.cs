using System;
using System.Collections.Generic;
using V2.DAL.InfraStructure;
using V2.InfraStructure;

namespace V2.DAL.Interfaces
{
    public class SqlRepo<T> : BaseRepository<T> where T : BaseEntity
    {
        public void Add(T p)
        {
            throw new NotImplementedException();
        }

        public void Edit(T p)
        {
            throw new NotImplementedException();
        }

        public T FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
