using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForgeShopRestApi.Models
{
    public class ForgeProductModel
    {
        public int Id { get; set; }
        public string ForgeProductName { get; set; }
        public decimal Price { get; set; }
    }
}