using Domain.Bookshelf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    /*
     * Implementation of the Repository class for Quote. I override the two get functions
     * here in order to include navigation properties that would otherwise not be brought
     * with when the call is made.
     */
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
