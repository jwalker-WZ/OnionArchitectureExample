using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Bookshelf
{
    public class Book : IEntity
    {
        public string Title { get; set; }
        public int? Length { get; set; }
        public string Author { get; set; }
        public double PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }

        public ICollection<Quote> Quotes { get; set; }
    }
}
