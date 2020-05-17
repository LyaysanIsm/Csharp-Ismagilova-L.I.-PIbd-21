using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopBusinessLogic.BindingModels
{
    public class StorageBilletBindingModel
    {
        public int Id { get; set; }
        public int StorageId { get; set; }
        public int BilletId { get; set; }
        public int Count { get; set; }
    }
}