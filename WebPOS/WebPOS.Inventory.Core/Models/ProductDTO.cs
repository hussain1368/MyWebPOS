using System;

namespace WebPOS.Inventory.Core.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public double Profit { get; set; }
        public double Discount { get; set; }
        public int InitialQuantity { get; set; }
        public int CurrentQuantity { get; set; }
        public int AlerQuantity { get; set; }
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Note { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
