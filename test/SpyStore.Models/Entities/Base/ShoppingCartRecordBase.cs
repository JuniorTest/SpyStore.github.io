using System.ComponentModel.DataAnnotations;
using System;

namespace SpyStore.Models.Entities.Base
{
    public class ShoppingCartRecordBase : EntityBase
    {
        [DataType(DataType.Date), Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int ProductId { get; set; }
        [DataType(DataType.Currency), Display(Name = "Line Total")]
        public decimal LineItemTotal { get; set; }
    }
}