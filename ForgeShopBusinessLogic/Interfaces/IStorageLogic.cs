using System;
using System.Collections.Generic;
using System.Text;
using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.ViewModels;

namespace ForgeShopBusinessLogic.Interfaces
{
    public interface IStorageLogic
    {
        List<StorageViewModel> GetList();
        StorageViewModel GetElement(int id);
        void AddElement(StorageBindingModel model);
        void UpdElement(StorageBindingModel model);
        void DelElement(StorageBindingModel model);
        void FillStorage(StorageBilletBindingModel model);
        void RemoveFromStorage(OrderViewModel model);
    }
}