using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ForgeShopBusinessLogic.ViewModels
{
    public class StorageBilletViewModel
    {
        public int Id { get; set; }
        public int StorageId { get; set; }
        public int BilletId { get; set; }
        [DisplayName("Название компонента")]
        public string BilletName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
    }
}