using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ForgeShopBusinessLogic.Enums;

namespace ForgeShopDatabaseImplement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [Required]
        public string ClientFIO { get; set; }
        public int ForgeProductId { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public decimal Sum { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
        public virtual ForgeProduct ForgeProduct { get; set; }
    }
}