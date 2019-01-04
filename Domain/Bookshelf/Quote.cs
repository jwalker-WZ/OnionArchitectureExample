using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Bookshelf
{
    public class Quote : IEntity
    {
        public string Text { get; set; }
        public string PageNumber { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
