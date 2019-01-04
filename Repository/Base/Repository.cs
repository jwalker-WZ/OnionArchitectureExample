using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        protected readonly AppContext context;
        protected DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(AppContext ac)
        {
            context = ac;
            entities = context.Set<T>();
        }

        public void Delete(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public virtual T Get(int id)
        {
            return entities.SingleOrDefault(e => e.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }
    }
}
