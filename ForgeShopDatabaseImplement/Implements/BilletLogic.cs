using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.Interfaces;
using ForgeShopBusinessLogic.ViewModels;
using ForgeShopDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForgeShopDatabaseImplement.Implements
{
    public class BilletLogic : IBilletLogic
    {
        public void CreateOrUpdate(BilletBindingModel model)
        {
            using (var context = new ForgeShopDatabase())
            {
                Billet element = context.Billets.FirstOrDefault(rec =>
               rec.BilletName == model.BilletName && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть компонент с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.Billets.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Billet();
                    context.Billets.Add(element);
                }
                element.BilletName = model.BilletName;
                context.SaveChanges();
            }
        }
        public void Delete(BilletBindingModel model)
        {
            using (var context = new ForgeShopDatabase())
            {
                Billet element = context.Billets.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Billets.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<BilletViewModel> Read(BilletBindingModel model)
        {
            using (var context = new ForgeShopDatabase())
            {
                return context.Billets
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new BilletViewModel
                {
                    Id = rec.Id,
                    BilletName = rec.BilletName
                })
                .ToList();
            }
        }
    }
}