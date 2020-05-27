using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace ForgeShopBusinessLogic.ViewModels
{
    [DataContract]
    public class StorageBilletViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int StorageId { get; set; }
        [DataMember]
        public int BilletId { get; set; }
        [DisplayName("Название склада")]
        [DataMember]
        public string StorageName { get; set; }
        [DisplayName("Название компонента")]
        [DataMember]
        public string BilletName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
    }
}