using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ForgeShopDatabaseImplement.Models
{
    /// <summary>
    /// Сколько компонентов, требуется при изготовлении изделия
    /// </summary>
    public class ForgeProductBillet
    {
        public int Id { get; set; }
        public int ForgeProductId { get; set; }
        public int BilletId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Billet Billet { get; set; }
        public virtual ForgeProduct ForgeProduct { get; set; }
    }
}