using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopBusinessLogic.BindingModels
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    public class ForgeProductBindingModel
    {
        public int? Id { get; set; }
        public string ForgeProductName { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> ForgeProductBillets { get; set; }
    }
}