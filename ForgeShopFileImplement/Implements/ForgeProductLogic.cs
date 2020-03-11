using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.Interfaces;
using ForgeShopBusinessLogic.ViewModels;
using ForgeShopFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ForgeShopFileImplement.Implements
{
    public class ForgeProductLogic : IForgeProductLogic
    {
        private readonly FileDataListSingleton source;
        public ForgeProductLogic()
        {
            source = FileDataListSingleton.GetInstance();
        }
        public void CreateOrUpdate(ForgeProductBindingModel model)
        {
            ForgeProduct element = source.ForgeProducts.FirstOrDefault(rec => rec.ForgeProductName ==
           model.ForgeProductName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть изделие с таким названием");
            }
            if (model.Id.HasValue)
            {
                element = source.ForgeProducts.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
            }
            else
            {
                int maxId = source.ForgeProducts.Count > 0 ? source.Billets.Max(rec =>
               rec.Id) : 0;
                element = new ForgeProduct { Id = maxId + 1 };
                source.ForgeProducts.Add(element);
            }
            element.ForgeProductName = model.ForgeProductName;
            element.Price = model.Price;
            // удалили те, которых нет в модели
            source.ForgeProductBillets.RemoveAll(rec => rec.ForgeProductId == model.Id &&
           !model.ForgeProductBillets.ContainsKey(rec.BilletId));
            // обновили количество у существующих записей
            var updateBillets = source.ForgeProductBillets.Where(rec => rec.ForgeProductId ==
           model.Id && model.ForgeProductBillets.ContainsKey(rec.BilletId));
            foreach (var updateBillet in updateBillets)
            {
                updateBillet.Count =
               model.ForgeProductBillets[updateBillet.BilletId].Item2;
                model.ForgeProductBillets.Remove(updateBillet.BilletId);
            }
            // добавили новые
            int maxPCId = source.ForgeProductBillets.Count > 0 ?
           source.ForgeProductBillets.Max(rec => rec.Id) : 0;
            foreach (var pc in model.ForgeProductBillets)
            {
                source.ForgeProductBillets.Add(new ForgeProductBillet
                {
                    Id = ++maxPCId,
                    ForgeProductId = element.Id,
                    BilletId = pc.Key,
                    Count = pc.Value.Item2
                });
            }
        }
        public void Delete(ForgeProductBindingModel model)
        {
            // удаяем записи по компонентам при удалении изделия
            source.ForgeProductBillets.RemoveAll(rec => rec.ForgeProductId == model.Id);
            ForgeProduct element = source.ForgeProducts.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.ForgeProducts.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public List<ForgeProductViewModel> Read(ForgeProductBindingModel model)
        {
            return source.ForgeProducts
            .Where(rec => model == null || rec.Id == model.Id)
            .Select(rec => new ForgeProductViewModel
            {
                Id = rec.Id,
                ForgeProductName = rec.ForgeProductName,
                Price = rec.Price,
                ForgeProductBillets = source.ForgeProductBillets
            .Where(recPC => recPC.ForgeProductId == rec.Id)
           .ToDictionary(recPC => recPC.BilletId, recPC =>
            (source.Billets.FirstOrDefault(recC => recC.Id ==
           recPC.BilletId)?.BilletName, recPC.Count))
            })
            .ToList();
        }
    }
}