using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Bookshelf;
using Repository;

namespace Service
{
    /*
     * specific implementation for quotes
     * 
     * The default implementation would work as well since there are no extra functions defined
     * 
     */
    public class QuoteService : IService<Quote>
    {

        IRepository<Quote> _repository;

        public QuoteService(IRepository<Quote> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            Quote quote = Get(id);
            _repository.Delete(quote);
        }

        public Quote Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Quote> Get()
        {
            var q = _repository.GetAll().ToList();
            return _repository.GetAll();
        }

        public void Insert(Quote quote)
        {
            _repository.Insert(quote);
        }

        public void Update(Quote quote)
        {
            _repository.Update(quote);
        }
    }
}
