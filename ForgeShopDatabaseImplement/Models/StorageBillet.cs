using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ForgeShopDatabaseImplement.Models
{
    public class StorageBillet
    {
        public int Id { get; set; }
        public int StorageId { get; set; }
        public int BilletId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Billet Billet { get; set; }
        public virtual Storage Storage { get; set; }
    }
}