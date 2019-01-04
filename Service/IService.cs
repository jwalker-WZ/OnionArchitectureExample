using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IService<T> where T : IEntity
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
