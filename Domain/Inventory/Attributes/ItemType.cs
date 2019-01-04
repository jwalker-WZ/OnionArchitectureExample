using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Inventory.Attributes
{
    public class ItemType : IEntity
    {
        public string Description { get; set; }
    }
}
