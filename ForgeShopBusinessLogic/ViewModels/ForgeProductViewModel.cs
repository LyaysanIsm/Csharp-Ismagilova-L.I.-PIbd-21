using ForgeShopBusinessLogic.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ForgeShopBusinessLogic.ViewModels
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    [DataContract]
    public class ForgeProductViewModel : BaseViewModel
    {
        [Column(title: "Название изделия", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        public string ForgeProductName { get; set; }
        [Column(title: "Цена", width: 50)]
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> ForgeProductBillets { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "ForgeProductName",
            "Price"
        };
    }
}