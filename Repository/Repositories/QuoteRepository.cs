using Domain.Bookshelf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class QuoteRepository : Repository<Quote>
    {
        public QuoteRepository(AppContext ac) : base(ac)
        {

        }

        public override Quote Get(int id)
        {
            return entities.Include(x => x.Book).SingleOrDefault();
        }

        public override IEnumerable<Quote> GetAll()
        {
            return entities.Include(x => x.Book).AsEnumerable();
        }
    }
}
