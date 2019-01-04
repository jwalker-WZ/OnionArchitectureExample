using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
