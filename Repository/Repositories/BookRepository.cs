using Domain.Bookshelf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class BookRepository : Repository<Book>
    {

        public BookRepository(AppContext ac) : base(ac)
        {

        }

        public override Book Get(int id)
        {
            return entities.Include(x => x.Quotes).SingleOrDefault();
        }

        public override IEnumerable<Book> GetAll()
        {
            return entities.Include(x => x.Quotes).AsEnumerable();
        }
    }
}
