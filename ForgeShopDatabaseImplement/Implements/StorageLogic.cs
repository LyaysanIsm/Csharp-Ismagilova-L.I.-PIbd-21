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
    public class StorageLogic : IStorageLogic
    {
        public List<StorageViewModel> GetList()
        {
            using (var context = new ForgeShopDatabase())
            {
                return context.Storages
                .ToList()
               .Select(rec => new StorageViewModel
               {
                   Id = rec.Id,
                   StorageName = rec.StorageName,
                   StorageBillets = context.StorageBillets
                .Include(recSF => recSF.Billet)
               .Where(recSF => recSF.StorageId == rec.Id).
               Select(x => new StorageBilletViewModel
               {
                   Id = x.Id,
                   StorageId = x.StorageId,
                   BilletId = x.BilletId,
                   BilletName = context.Billets.FirstOrDefault(y => y.Id == x.BilletId).BilletName,
                   Count = x.Count
               })
               .ToList()
               })
            .ToList();
            }
        }
        public StorageViewModel GetElement(int id)
        {
            using (var context = new ForgeShopDatabase())
            {
                var elem = context.Storages.FirstOrDefault(x => x.Id == id);
                if (elem == null)
                {
                    throw new Exception("Элемент не найден");
                }
                else
                {
                    return new StorageViewModel
                    {
                        Id = id,
                        StorageName = elem.StorageName,
                        StorageBillets = context.StorageBillets
                .Include(recSF => recSF.Billet)
               .Where(recSF => recSF.StorageId == elem.Id)
                        .Select(x => new StorageBilletViewModel
                        {
                            Id = x.Id,
                            StorageId = x.StorageId,
                            BilletId = x.BilletId,
                            BilletName = context.Billets.FirstOrDefault(y => y.Id == x.BilletId).BilletName,
                            Count = x.Count
                        }).ToList()
                    };
                }
            }
        }
        public void AddElement(StorageBindingModel model)
        {
            using (var context = new ForgeShopDatabase())
            {
                var elem = context.Storages.FirstOrDefault(x => x.StorageName == model.StorageName);
                if (elem != null)
                {
                    throw new Exception("Уже есть склад с таким названием");
                }
                var storage = new Storage();
                context.Storages.Add(storage);
                storage.StorageName = model.StorageName;
                context.SaveChanges();
            }
        }
        public void UpdElement(StorageBindingModel model)
        {
            using (var context = new ForgeShopDatabase())
            {
                var elem = context.Storages.FirstOrDefault(x => x.StorageName == model.StorageName && x.Id != model.Id);
                if (elem != null)
                {
                    throw new Exception("Уже есть склад с таким названием");
                }
                var elemToUpdate = context.Storages.FirstOrDefault(x => x.Id == model.Id);
                if (elemToUpdate != null)
                {
                    elemToUpdate.StorageName = model.StorageName;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public void DelElement(int id)
        {
            using (var context = new ForgeShopDatabase())
            {
                var elem = context.Storages.FirstOrDefault(x => x.Id == id);
                if (elem != null)
                {
                    context.Storages.Remove(elem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public void FillStorage(StorageBilletBindingModel model)
        {
            using (var context = new ForgeShopDatabase())
            {
                var item = context.StorageBillets.FirstOrDefault(x => x.BilletId == model.BilletId
    && x.StorageId == model.StorageId);

                if (item != null)
                {
                    item.Count += model.Count;
                }
                else
                {
                    var elem = new StorageBillet();
                    context.StorageBillets.Add(elem);
                    elem.StorageId = model.StorageId;
                    elem.BilletId = model.BilletId;
                    elem.Count = model.Count;
                }
                context.SaveChanges();
            }
        }
        public void RemoveFromStorage(OrderViewModel order)
        {
            using (var context = new ForgeShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var forgeproductBillets = context.ForgeProductBillets.Where(x => x.ForgeProductId == order.ForgeProductId).ToList();
                        var StorageBillets = context.StorageBillets.ToList();
                        foreach (var billet in forgeproductBillets)
                        {
                            var billetCount = billet.Count * order.Count;
                            foreach (var sb in StorageBillets)
                            {
                                if (sb.BilletId == billet.BilletId && sb.Count >= billetCount)
                                {
                                    sb.Count -= billetCount;
                                    billetCount = 0;
                                    context.SaveChanges();
                                    break;
                                }
                                else if (sb.BilletId == billet.BilletId && sb.Count < billetCount)
                                {
                                    billetCount -= sb.Count;
                                    sb.Count = 0;
                                    context.SaveChanges();
                                }
                            }
                            if (billetCount > 0)
                                throw new Exception("Недостаточно компонентов на складе");
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
    }
}