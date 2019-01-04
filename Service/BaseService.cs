using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    //Default implementation of the generic service
    public class BaseService<T> : IService<T> where T : IEntity
    {
        IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            T item = Get(id);
            _repository.Delete(item);
        }

        public IEnumerable<T> Get()
        {
            return _repository.GetAll();
        }

        public T Get(int id)
        {
            return _repository.Get(id);
        }

        public void Insert(T entity)
        {
            _repository.Insert(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
