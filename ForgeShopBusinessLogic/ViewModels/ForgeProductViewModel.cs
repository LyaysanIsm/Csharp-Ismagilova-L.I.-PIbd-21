using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ForgeShopBusinessLogic.ViewModels
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    [DataContract]
    public class ForgeProductViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [DisplayName("Название изделия")]
        public string ForgeProductName { get; set; }
        [DataMember]
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> ForgeProductBillets { get; set; }
    }
}