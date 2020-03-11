using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopFileImplement.Models
{
    public class ForgeProductBillet
    {
        public int Id { get; set; }
        public int ForgeProductId { get; set; }
        public int BilletId { get; set; }
        public int Count { get; set; }
    }
}