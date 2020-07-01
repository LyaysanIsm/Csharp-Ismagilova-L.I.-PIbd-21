using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopListImplement.Models
{
    /// <summary>
    /// Компонент, требуемый для изготовления изделия
    /// </summary>
    public class Billet
    {
        public int Id { get; set; }
        public string BilletName { get; set; }
    }
}