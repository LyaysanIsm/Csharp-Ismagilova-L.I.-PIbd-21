using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.Interfaces;
using ForgeShopBusinessLogic.ViewModels;
using ForgeShopListImplement.Models;
using System;
using System.Collections.Generic;

namespace ForgeShopListImplement.Implements
{
    public class ForgeProductLogic : IForgeProductLogic
    {
        private readonly DataListSingleton source;
        public ForgeProductLogic()
        {
            source = DataListSingleton.GetInstance();
        }

        public void CreateOrUpdate(ForgeProductBindingModel model)
        {
            ForgeProduct tempForgeProduct = model.Id.HasValue ? null : new ForgeProduct { Id = 1 };
            foreach (var forgeproduct in source.ForgeProducts)
            {
                if (forgeproduct.ForgeProductName == model.ForgeProductName && forgeproduct.Id != model.Id)
                {
                    throw new Exception("Уже есть изделие с таким названием");
                }
                if (!model.Id.HasValue && forgeproduct.Id >= tempForgeProduct.Id)
                {
                    tempForgeProduct.Id = forgeproduct.Id + 1;
                }
                else if (model.Id.HasValue && forgeproduct.Id == model.Id)
                {
                    tempForgeProduct = forgeproduct;
                }
            }
            if (model.Id.HasValue)
            {
                if (tempForgeProduct == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, tempForgeProduct);
            }
            else
            {
                source.ForgeProducts.Add(CreateModel(model, tempForgeProduct));
            }
        }
        public void Delete(ForgeProductBindingModel model)
        {
            // удаляем записи по компонентам при удалении изделия
            for (int i = 0; i < source.ForgeProductBillets.Count; ++i)
            {
                if (source.ForgeProductBillets[i].ForgeProductId == model.Id)
                {
                    source.ForgeProductBillets.RemoveAt(i--);
                }
            }
            for (int i = 0; i < source.ForgeProducts.Count; ++i)
            {
                if (source.ForgeProducts[i].Id == model.Id)
                {
                    source.ForgeProducts.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        private ForgeProduct CreateModel(ForgeProductBindingModel model, ForgeProduct Forgeproduct)
        {
            Forgeproduct.ForgeProductName = model.ForgeProductName;
            Forgeproduct.Price = model.Price;
            //обновляем существуюущие компоненты и ищем максимальный идентификатор
            int maxPCId = 0;
            for (int i = 0; i < source.ForgeProductBillets.Count; ++i)
            {
                if (source.ForgeProductBillets[i].Id > maxPCId)
                {
                    maxPCId = source.ForgeProductBillets[i].Id;
                }
                if (source.ForgeProductBillets[i].ForgeProductId == Forgeproduct.Id)
                {
                    // если в модели пришла запись компонента с таким id
                    if
                    (model.ForgeProductBillets.ContainsKey(source.ForgeProductBillets[i].BilletId))
                    {
                        // обновляем количество
                        source.ForgeProductBillets[i].Count =
                        model.ForgeProductBillets[source.ForgeProductBillets[i].BilletId].Item2;
                        // из модели убираем эту запись, чтобы остались только не
                        // просмотренные


                        model.ForgeProductBillets.Remove(source.ForgeProductBillets[i].BilletId);
                    }
                    else
                    {
                        source.ForgeProductBillets.RemoveAt(i--);
                    }
                }
            }
            // новые записи
            foreach (var pc in model.ForgeProductBillets)
            {
                source.ForgeProductBillets.Add(new ForgeProductBillet
                {
                    Id = ++maxPCId,
                    ForgeProductId = Forgeproduct.Id,
                    BilletId = pc.Key,
                    Count = pc.Value.Item2
                });
            }
            return Forgeproduct;
        }
        public List<ForgeProductViewModel> Read(ForgeProductBindingModel model)
        {
            List<ForgeProductViewModel> result = new List<ForgeProductViewModel>();
            foreach (var billet in source.ForgeProducts)
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
        private ForgeProductViewModel CreateViewModel(ForgeProduct Forgeproduct)
        {
            // требуется дополнительно получить список компонентов для изделия с
            //названиями и их количество
            Dictionary<int, (string, int)> forgeproductBillets = new Dictionary<int,
    (string, int)>();
            foreach (var pc in source.ForgeProductBillets)
            {
                if (pc.ForgeProductId == Forgeproduct.Id)
                {
                    string billetName = string.Empty;
                    foreach (var billet in source.Billets)
                    {
                        if (pc.BilletId == billet.Id)
                        {
                            billetName = billet.BilletName;
                            break;
                        }
                    }
                    forgeproductBillets.Add(pc.BilletId, (billetName, pc.Count));
                }
            }
            return new ForgeProductViewModel
            {
                Id = Forgeproduct.Id,
                ForgeProductName = Forgeproduct.ForgeProductName,
                Price = Forgeproduct.Price,
                ForgeProductBillets = forgeproductBillets
            };
        }
    }
}