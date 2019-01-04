using Domain.Inventory.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Inventory
{
    public class InventoryItem : IEntity
    {
        public string Description { get; set; }
        public double PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SerialNumber { get; set; }

        public int ItemTypeId { get; set; }
        public ItemType ItemType { get; set; }

        public int ItemColorId { get; set; }
        public ItemColor ItemColor { get; set; }
    }
}
