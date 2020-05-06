using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopListImplement.Models
{
    public class StorageBillet
    {
        public int Id { get; set; }
        public int StorageId { get; set; }
        public int BilletId { get; set; }
        public int Count { get; set; }
    }
}