using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopBusinessLogic.Interfaces
{
    public interface IMessageInfoLogic
    {
        List<MessageInfoViewModel> Read(MessageInfoBindingModel model);
        void Create(MessageInfoBindingModel model);
    }
}