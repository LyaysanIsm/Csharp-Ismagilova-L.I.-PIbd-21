using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ForgeShopBusinessLogic.BindingModels
{
    [DataContract]
    public class StorageBilletBindingModel
    {
        public int Id { get; set; }
        public int StorageId { get; set; }
        public int BilletId { get; set; }
        public int Count { get; set; }
    }
}