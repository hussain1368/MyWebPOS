using System;
using System.Collections.Generic;

#nullable disable

namespace WebPOS.Inventory.Infrastructure.Domain
{
    public partial class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
    }
}
