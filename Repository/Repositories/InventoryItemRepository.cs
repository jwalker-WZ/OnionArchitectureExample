using Domain.Inventory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    /*
     * Implementation of the Repository class for Inventory. I override the two get functions
     * here in order to include navigation properties that would otherwise not be brought
     * with when the call is made.
     */
    public class InventoryItemRepository : Repository<InventoryItem>
    {
        public InventoryItemRepository(AppContext ac) : base(ac)
        {

        }

        public override InventoryItem Get(int id)
        {
            return entities.Include(x => x.ItemColor).Include(x => x.ItemType).SingleOrDefault();
        }

        public override IEnumerable<InventoryItem> GetAll()
        {
            return entities.Include(x => x.ItemColor).Include(x => x.ItemType).AsEnumerable();
        }
    }
}
