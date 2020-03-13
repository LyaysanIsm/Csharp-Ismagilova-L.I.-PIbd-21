using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopBusinessLogic.BindingModels
{
    public class StorageBindingModel
    {
        public int Id { get; set; }
        public string StorageName { get; set; }
        public List<StorageBilletBindingModel> StorageBillets { get; set; }
    }
}