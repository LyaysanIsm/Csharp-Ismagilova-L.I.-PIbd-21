using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForgeShopDatabaseImplement.Models
{
    /// <summary>
    /// Компонент, требуемый для изготовления изделия
    /// </summary>
    public class Billet
    {
        public int Id { get; set; }
        [Required]
        public string BilletName { get; set; }
        [ForeignKey("BilletId")]
        public virtual List<ForgeProductBillet> ForgeProductBillets { get; set; }
    }
}