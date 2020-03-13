using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForgeShopDatabaseImplement.Models
{
    public class ForgeProduct
    {
        public int Id { get; set; }
        [Required]
        public string ForgeProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual List<ForgeProductBillet> ForgeProductBillets { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}