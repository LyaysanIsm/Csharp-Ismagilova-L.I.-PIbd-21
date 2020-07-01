using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ForgeShopBusinessLogic.BindingModels
{
    [DataContract]
    public class StorageBilletBindingModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int StorageId { get; set; }
        [DataMember]
        public int BilletId { get; set; }
        [DataMember]
        public int Count { get; set; }
    }
}