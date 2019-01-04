using System;
using System.Collections.Generic;
using System.Text;
using Domain.Bookshelf;
using Repository;

namespace Service
{
    public class BookService : IService<Book>
    {
        private IRepository<Book> _repository;

        public BookService(IRepository<Book> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            Book b = Get(id);
            _repository.Delete(b);
        }

        public Book Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Book> Get()
        {
            return _repository.GetAll();
        }

        public void Insert(Book entity)
        {
            _repository.Insert(entity);
        }

        public void Update(Book entity)
        {
            _repository.Update(entity);
        }
    }
}
