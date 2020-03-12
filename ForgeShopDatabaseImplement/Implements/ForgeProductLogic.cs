using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.Interfaces;
using ForgeShopBusinessLogic.ViewModels;
using ForgeShopDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForgeShopDatabaseImplement.Implements
{
    public class ForgeProductLogic : IForgeProductLogic
    {
        public void CreateOrUpdate(ForgeProductBindingModel model)
        {
            using (var context = new ForgeShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        ForgeProduct element = context.ForgeProducts.FirstOrDefault(rec =>
                       rec.ForgeProductName == model.ForgeProductName && rec.Id != model.Id);
                        if (element != null)
                        {
                            throw new Exception("Уже есть изделие с таким названием");
                        }
                        if (model.Id.HasValue)
                        {
                            element = context.ForgeProducts.FirstOrDefault(rec => rec.Id ==
                           model.Id);
                            if (element == null)
                            {
                                throw new Exception("Элемент не найден");
                            }
                        }
                        else
                        {
                            element = new ForgeProduct();
                            context.ForgeProducts.Add(element);
                        }
                        element.ForgeProductName = model.ForgeProductName;
                        element.Price = model.Price;
                        context.SaveChanges();
                        if (model.Id.HasValue)
                        {
                            var forgeProductBillets = context.ForgeProductBillets.Where(rec
                           => rec.ForgeProductId == model.Id.Value).ToList();
                            // удалили те, которых нет в модели
                            context.ForgeProductBillets.RemoveRange(forgeProductBillets.Where(rec =>
                            !model.ForgeProductBillets.ContainsKey(rec.BilletId)).ToList());
                            context.SaveChanges();
                            // обновили количество у существующих записей
                            foreach (var updateBillet in forgeProductBillets)
                            {
                                updateBillet.Count =
                               model.ForgeProductBillets[updateBillet.BilletId].Item2;

                                model.ForgeProductBillets.Remove(updateBillet.BilletId);
                            }
                            context.SaveChanges();
                        }
                        // добавили новые
                        foreach (var pc in model.ForgeProductBillets)
                        {
                            context.ForgeProductBillets.Add(new ForgeProductBillet
                            {
                                ForgeProductId = element.Id,
                                BilletId = pc.Key,
                                Count = pc.Value.Item2
                            });
                            context.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(ForgeProductBindingModel model)
        {
            using (var context = new ForgeShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // удаяем записи по компонентам при удалении изделия
                        context.ForgeProductBillets.RemoveRange(context.ForgeProductBillets.Where(rec =>
                        rec.ForgeProductId == model.Id));
                        ForgeProduct element = context.ForgeProducts.FirstOrDefault(rec => rec.Id
                        == model.Id);
                        if (element != null)
                        {
                            context.ForgeProducts.Remove(element);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Элемент не найден");
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<ForgeProductViewModel> Read(ForgeProductBindingModel model)
        {
            using (var context = new ForgeShopDatabase())
            {
                return context.ForgeProducts
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
               .Select(rec => new ForgeProductViewModel
               {
                   Id = rec.Id,
                   ForgeProductName = rec.ForgeProductName,
                   Price = rec.Price,
                   ForgeProductBillets = context.ForgeProductBillets
                .Include(recPC => recPC.Billet)
               .Where(recPC => recPC.ForgeProductId == rec.Id)
               .ToDictionary(recPC => recPC.BilletId, recPC =>
                (recPC.Billet?.BilletName, recPC.Count))
               })
               .ToList();
            }
        }
    }
}