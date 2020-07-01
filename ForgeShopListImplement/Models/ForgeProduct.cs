using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopListImplement.Models
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    public class ForgeProduct
    {
        public int Id { get; set; }
        public string ForgeProductName { get; set; }
        public decimal Price { get; set; }
    }
}