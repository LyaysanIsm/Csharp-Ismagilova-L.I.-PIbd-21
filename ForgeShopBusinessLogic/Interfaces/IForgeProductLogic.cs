using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace ForgeShopBusinessLogic.Interfaces
{
    public interface IForgeProductLogic
    {
        List<ForgeProductViewModel> Read(ForgeProductBindingModel model);
        void CreateOrUpdate(ForgeProductBindingModel model);
        void Delete(ForgeProductBindingModel model);
    }
}