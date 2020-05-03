using ForgeShopBusinessLogic.Interfaces;
using ForgeShopBusinessLogic.ViewModels;
using ForgeShopFileImplement.Models;
using ForgeShopBusinessLogic.BindingModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ForgeShopFileImplement.Implements
{
    public class StorageLogic : IStorageLogic
    {
        private readonly FileDataListSingleton source;
        public StorageLogic()
        {
            source = FileDataListSingleton.GetInstance();
        }
        public List<StorageViewModel> GetList()
        {
            return source.Storages.Select(rec => new StorageViewModel
            {
                Id = rec.Id,
                StorageName = rec.StorageName,
                StorageBillets = source.StorageBillets.Where(z => z.StorageId == rec.Id).Select(x => new StorageBilletViewModel
                {
                    Id = x.Id,
                    StorageId = x.StorageId,
                    BilletId = x.BilletId,
                    BilletName = source.Billets.FirstOrDefault(y => y.Id == x.BilletId)?.BilletName,
                    Count = x.Count
                }).ToList()
            })
                .ToList();
        }
        public StorageViewModel GetElement(int id)
        {
            var elem = source.Storages.FirstOrDefault(x => x.Id == id);
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
                    StorageBillets = source.StorageBillets.Where(z => z.StorageId == elem.Id).Select(x => new StorageBilletViewModel
                    {
                        Id = x.Id,
                        StorageId = x.StorageId,
                        BilletId = x.BilletId,
                        BilletName = source.Billets.FirstOrDefault(y => y.Id == x.BilletId)?.BilletName,
                        Count = x.Count
                    }).ToList()
                };
            }
        }

        public void AddElement(StorageBindingModel model)
        {

            var elem = source.Storages.FirstOrDefault(x => x.StorageName == model.StorageName);
            if (elem != null)
            {
                throw new Exception("Уже есть склад с таким названием");
            }
            int maxId = source.Storages.Count > 0 ? source.Storages.Max(rec => rec.Id) : 0;
            source.Storages.Add(new Storage
            {
                Id = maxId + 1,
                StorageName = model.StorageName
            });
        }
        public void UpdElement(StorageBindingModel model)
        {
            var elem = source.Storages.FirstOrDefault(x => x.StorageName == model.StorageName && x.Id != model.Id);
            if (elem != null)
            {
                throw new Exception("Уже есть склад с таким названием");
            }
            var elemToUpdate = source.Storages.FirstOrDefault(x => x.Id == model.Id);
            if (elemToUpdate != null)
            {
                elemToUpdate.StorageName = model.StorageName;
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public void DelElement(int id)
        {
            var elem = source.Storages.FirstOrDefault(x => x.Id == id);
            if (elem != null)
            {
                source.Storages.Remove(elem);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public void FillStorage(StorageBilletBindingModel model)
        {
            var item = source.StorageBillets.FirstOrDefault(x => x.BilletId == model.BilletId
                    && x.StorageId == model.StorageId);

            if (item != null)
            {
                item.Count += model.Count;
            }
            else
            {
                int maxId = source.StorageBillets.Count > 0 ? source.StorageBillets.Max(rec => rec.Id) : 0;
                source.StorageBillets.Add(new StorageBillet
                {
                    Id = maxId + 1,
                    StorageId = model.StorageId,
                    BilletId = model.BilletId,
                    Count = model.Count
                });
            }
        }

        public bool CheckBilletsAvailability(int ForgeProductId, int ForgeProductsCount)
        {
            bool result = true;
            var ForgeProductBillets = source.ForgeProductBillets.Where(x => x.ForgeProductId == ForgeProductId);
            if (ForgeProductBillets.Count() == 0) return false;
            foreach (var elem in ForgeProductBillets)
            {
                int count = 0;
                var storageBillets = source.StorageBillets.FindAll(x => x.BilletId == elem.BilletId);
                count = storageBillets.Sum(x => x.Count);
                if (count < elem.Count * ForgeProductsCount)
                    return false;
            }
            return result;
        }

        public void RemoveFromStorage(OrderViewModel model)
        {
            var forgeproductBillets = source.ForgeProductBillets.Where(rec => rec.Id == model.ForgeProductId).ToList();
            foreach (var pc in forgeproductBillets)
            {
                var storageBillets = source.StorageBillets.Where(rec => rec.BilletId == pc.BilletId);
                int sum = storageBillets.Sum(rec => rec.Count);
                if (sum < pc.Count * model.Count)
                {
                    throw new Exception("Недостаточно компонентов на складе");
                }
                else
                {
                    int left = pc.Count * model.Count;
                    foreach (var sb in storageBillets)
                    {
                        if (sb.Count >= left)
                        {
                            sb.Count -= left;
                            break;
                        }
                        else
                        {
                            left -= sb.Count;
                            sb.Count = 0;
                        }
                    }
                }
            }
        }
    }
}