using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using SpyStore.Models.Entities.Base;
using System.Collections.Generic;

namespace SpyStore.Models.Entities
{
    [Table("Products", Schema = "Store")]
    public class Product : EntityBase
    {
        public ProductDetail Details { get; set; } = new ProductDetail();
        public bool IsFeatured { get; set; }
        [DataType(DataType.Currency)]
        public decimal UnitCost { get; set; }
        [DataType(DataType.Currency)]
        public decimal CurrentPrice { get; set; }
        public int UnitsInStock { get; set; }
        [Required]
        public int CategoryId { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(CategoryId))]
        public Category CategoryNavigation { get; set; }
        [InverseProperty(nameof(ShoppingCartRecord.ProductNavigation))]  
        public List<ShoppingCartRecord> ShoppingCartRecords { get; set; } = new List<ShoppingCartRecord>();  
        [InverseProperty(nameof(OrderDetail.ProductNavigation))]  
        public List<OrderDetail> OrderDetails { get; set; }= new List<OrderDetail>();  
        [NotMapped]  
        public string CategoryName => CategoryNavigation?.CategoryName;
    }
}