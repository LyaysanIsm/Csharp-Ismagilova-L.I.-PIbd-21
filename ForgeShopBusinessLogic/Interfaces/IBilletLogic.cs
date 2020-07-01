using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace ForgeShopBusinessLogic.Interfaces
{
    public interface IBilletLogic
    {
        List<BilletViewModel> Read(BilletBindingModel model);
        void CreateOrUpdate(BilletBindingModel model);
        void Delete(BilletBindingModel model);
    }
}