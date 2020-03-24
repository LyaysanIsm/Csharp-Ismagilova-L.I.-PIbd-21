using ForgeShopBusinessLogic.ViewModels;
using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.Interfaces;
using ForgeShopListImplement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ForgeShopListImplement.Implements
{
    public class StorageLogic : IStorageLogic
    {
        private readonly DataListSingleton source;
        public StorageLogic()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<StorageViewModel> GetList()
        {
            List<StorageViewModel> result = new List<StorageViewModel>();
            for (int i = 0; i < source.Storages.Count; ++i)
            {
                List<StorageBilletViewModel> StorageBillets = new
    List<StorageBilletViewModel>();
                for (int j = 0; j < source.StorageBillets.Count; ++j)
                {
                    if (source.StorageBillets[j].StorageId == source.Storages[i].Id)
                    {
                        string BilletName = string.Empty;
                        for (int k = 0; k < source.Billets.Count; ++k)
                        {
                            if (source.StorageBillets[j].BilletId ==
                           source.Billets[k].Id)
                            {
                                BilletName = source.Billets[k].BilletName;
                                break;
                            }
                        }
                        StorageBillets.Add(new StorageBilletViewModel
                        {
                            Id = source.StorageBillets[j].Id,
                            StorageId = source.StorageBillets[j].StorageId,
                            BilletId = source.StorageBillets[j].BilletId,
                            BilletName = BilletName,
                            Count = source.StorageBillets[j].Count
                        });
                    }
                }
                result.Add(new StorageViewModel
                {
                    Id = source.Storages[i].Id,
                    StorageName = source.Storages[i].StorageName,
                    StorageBillets = StorageBillets
                });
            }
            return result;
        }
        public StorageViewModel GetElement(int id)
        {
            for (int i = 0; i < source.Storages.Count; ++i)
            {
                List<StorageBilletViewModel> StorageBillets = new
    List<StorageBilletViewModel>();
                for (int j = 0; j < source.StorageBillets.Count; ++j)
                {
                    if (source.StorageBillets[j].StorageId == source.Storages[i].Id)
                    {
                        string BilletName = string.Empty;
                        for (int k = 0; k < source.Billets.Count; ++k)
                        {
                            if (source.StorageBillets[j].BilletId ==
                           source.Billets[k].Id)
                            {
                                BilletName = source.Billets[k].BilletName;
                                break;
                            }
                        }
                        StorageBillets.Add(new StorageBilletViewModel
                        {
                            Id = source.StorageBillets[j].Id,
                            StorageId = source.StorageBillets[j].StorageId,
                            BilletId = source.StorageBillets[j].BilletId,
                            BilletName = BilletName,
                            Count = source.StorageBillets[j].Count
                        });
                    }
                }
                if (source.Storages[i].Id == id)
                {
                    return new StorageViewModel
                    {
                        Id = source.Storages[i].Id,
                        StorageName = source.Storages[i].StorageName,
                        StorageBillets = StorageBillets
                    };
                }
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(StorageBindingModel model)
        {
            int maxId = 0;
            for (int i = 0; i < source.Storages.Count; ++i)
            {
                if (source.Storages[i].Id > maxId)
                {
                    maxId = source.Storages[i].Id;
                }
                if (source.Storages[i].StorageName == model.StorageName)
                {
                    throw new Exception("Уже есть склад с таким названием");
                }
            }
            source.Storages.Add(new Storage
            {
                Id = maxId + 1,
                StorageName = model.StorageName
            });
        }
        public void UpdElement(StorageBindingModel model)
        {
            int index = -1;
            for (int i = 0; i < source.Storages.Count; ++i)
            {
                if (source.Storages[i].Id == model.Id)
                {
                    index = i;
                }
                if (source.Storages[i].StorageName == model.StorageName &&
                source.Storages[i].Id != model.Id)
                {
                    throw new Exception("Уже есть склад с таким названием");
                }
            }
            if (index == -1)
            {
                throw new Exception("Элемент не найден");
            }
            source.Storages[index].StorageName = model.StorageName;
        }
        public void DelElement(int id)
        {
            for (int i = 0; i < source.StorageBillets.Count; ++i)
            {
                if (source.StorageBillets[i].StorageId == id)
                {
                    source.StorageBillets.RemoveAt(i--);
                }
            }
            for (int i = 0; i < source.Storages.Count; ++i)
            {
                if (source.Storages[i].Id == id)
                {
                    source.Storages.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
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
        public void RemoveFromStorage(int ForgeProductId, int ForgeProductsCount)
        {
            var ForgeProductBillets = source.ForgeProductBillets.Where(x => x.ForgeProductId == ForgeProductId);
            if (ForgeProductBillets.Count() == 0) return;
            foreach (var elem in ForgeProductBillets)
            {
                int left = elem.Count * ForgeProductsCount;
                var storageBillets = source.StorageBillets.FindAll(x => x.BilletId == elem.BilletId);
                foreach (var rec in storageBillets)
                {
                    int toRemove = left > rec.Count ? rec.Count : left;
                    rec.Count -= toRemove;
                    left -= toRemove;
                    if (left == 0) break;
                }
            }
            return;
        }
        public void FillStorage(StorageBilletBindingModel model)
        {
            int foundItemIndex = -1;
            for (int i = 0; i < source.StorageBillets.Count; ++i)
            {
                if (source.StorageBillets[i].BilletId == model.BilletId
                    && source.StorageBillets[i].StorageId == model.StorageId)
                {
                    foundItemIndex = i;
                    break;
                }
            }
            if (foundItemIndex != -1)
            {
                source.StorageBillets[foundItemIndex].Count =
                    source.StorageBillets[foundItemIndex].Count + model.Count;
            }
            else
            {
                int maxId = 0;
                for (int i = 0; i < source.StorageBillets.Count; ++i)
                {
                    if (source.StorageBillets[i].Id > maxId)
                    {
                        maxId = source.StorageBillets[i].Id;
                    }
                }
                source.StorageBillets.Add(new StorageBillet
                {
                    Id = maxId + 1,
                    StorageId = model.StorageId,
                    BilletId = model.BilletId,
                    Count = model.Count
                });
            }
        }
    }
}