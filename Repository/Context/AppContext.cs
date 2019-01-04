using Domain.Bookshelf;
using Domain.Inventory;
using Domain.Inventory.Attributes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    /*
     * This is the application context that is created for the entire project
     * In it I declare the different database tables (DbSet) as well as change
     * the default naming.
     */
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<ItemColor> ItemColors { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //This changes the default naming. Normaly the tables would be plurals.
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Quote>().ToTable("Quote");
            modelBuilder.Entity<ItemColor>().ToTable("ItemColor");
            modelBuilder.Entity<ItemType>().ToTable("ItemType");
            modelBuilder.Entity<InventoryItem>().ToTable("InventoryItem");
        }
    }
}
