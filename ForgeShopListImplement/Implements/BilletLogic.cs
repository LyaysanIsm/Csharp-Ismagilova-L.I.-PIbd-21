using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.Interfaces;
using ForgeShopBusinessLogic.ViewModels;
using ForgeShopListImplement.Models;
using System;
using System.Collections.Generic;

namespace ForgeShopListImplement.Implements
{
    public class BilletLogic : IBilletLogic
    {
        private readonly DataListSingleton source;
        public BilletLogic()
        {
            source = DataListSingleton.GetInstance();
        }
        public void CreateOrUpdate(BilletBindingModel model)
        {
            Billet tempBillet = model.Id.HasValue ? null : new Billet
            {
                Id = 1
            };
            foreach (var billet in source.Billets)
            {
                if (billet.BilletName == model.BilletName && billet.Id !=
               model.Id)
                {
                    throw new Exception("Уже есть заготовка с таким названием");
                }
                if (!model.Id.HasValue && billet.Id >= tempBillet.Id)
                {
                    tempBillet.Id = billet.Id + 1;
                }
                else if (model.Id.HasValue && billet.Id == model.Id)
                {
                    tempBillet = billet;
                }
            }
            if (model.Id.HasValue)
            {
                if (tempBillet == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, tempBillet);
            }
            else
            {
                source.Billets.Add(CreateModel(model, tempBillet));
            }
        }
        public void Delete(BilletBindingModel model)
        {
            for (int i = 0; i < source.Billets.Count; ++i)
            {
                if (source.Billets[i].Id == model.Id.Value)
                {
                    source.Billets.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        public List<BilletViewModel> Read(BilletBindingModel model)
        {
            List<BilletViewModel> result = new List<BilletViewModel>();
            foreach (var billet in source.Billets)
            {
                if (model != null)
                {
                    if (billet.Id == model.Id)
                    {
                        result.Add(CreateViewModel(billet));
                        break;
                    }
                    continue;
                }
                result.Add(CreateViewModel(billet));
            }
            return result;
        }
        private Billet CreateModel(BilletBindingModel model, Billet billet)
        {
            billet.BilletName = model.BilletName;
            return billet;
        }
        private BilletViewModel CreateViewModel(Billet billet)
        {
            return new BilletViewModel
            {
                Id = billet.Id,
                BilletName = billet.BilletName
            };
        }
    }
}