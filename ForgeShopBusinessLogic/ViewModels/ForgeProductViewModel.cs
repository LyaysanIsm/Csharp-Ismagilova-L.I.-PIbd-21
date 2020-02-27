using System.Collections.Generic;
using System.ComponentModel;

namespace ForgeShopBusinessLogic.ViewModels
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    public class ForgeProductViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название изделия")]
        public string ForgeProductName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> ForgeProductBillets { get; set; }
    }
}