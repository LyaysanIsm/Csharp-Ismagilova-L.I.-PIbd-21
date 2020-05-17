using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.HelperModels;
using ForgeShopBusinessLogic.Interfaces;
using ForgeShopBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForgeShopBusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly IForgeProductLogic forgeproductLogic;
        private readonly IOrderLogic orderLogic;
        private readonly IStorageLogic storageLogic;
        public ReportLogic(IForgeProductLogic forgeproductLogic, IOrderLogic orderLLogic, IStorageLogic storageLogic)
        {
            this.forgeproductLogic = forgeproductLogic;
            this.orderLogic = orderLLogic;
            this.storageLogic = storageLogic;
        }
        /// <summary>
        /// Получение списка компонент с указанием, в каких изделиях используются
        /// </summary>
        /// <returns></returns>
        public List<ReportForgeProductBilletViewModel> GetForgeProductBillet()
        {
            var forgeproducts = forgeproductLogic.Read(null);
            var list = new List<ReportForgeProductBilletViewModel>();
            foreach (var forgeproduct in forgeproducts)
            {
                foreach (var fb in forgeproduct.ForgeProductBillets)
                {
                    var record = new ReportForgeProductBilletViewModel
                    {
                        ForgeProductName = forgeproduct.ForgeProductName,
                        BilletName = fb.Value.Item1,
                        Count = fb.Value.Item2
                    };
                    list.Add(record);
                }
            }
            return list;
        }
        public List<ReportStorageBilletViewModel> GetStorageBillets()
        {
            var storages = storageLogic.GetList();
            var list = new List<ReportStorageBilletViewModel>();
            foreach (var storage in storages)
            {
                foreach (var sz in storage.StorageBillets)
                {
                    var record = new ReportStorageBilletViewModel
                    {
                        StorageName = storage.StorageName,
                        BilletName = sz.BilletName,
                        Count = sz.Count
                    };

                    list.Add(record);
                }
            }
            return list;
        }
        /// <summary>
        /// Получение списка заказов за определенный период
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<IGrouping<DateTime, OrderViewModel>> GetOrders(ReportBindingModel model)
        {
            var list = orderLogic
           .Read(new OrderBindingModel
           {
               DateFrom = model.DateFrom,
               DateTo = model.DateTo
           })
            .GroupBy(rec => rec.DateCreate.Date)
            .OrderBy(recG => recG.Key)
            .ToList();
            return list;
        }
        /// <summary>
        /// Сохранение изделий в файл-Word
        /// </summary>
        /// <param name="model"></param>
        public void SaveForgeProductsToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "The list of forgeproducts",
                ForgeProducts = forgeproductLogic.Read(null)
            });
        }
        /// <summary>
        /// Сохранение изделий в файл-Excel
        /// </summary>
        /// <param name="model"></param>
        public void SaveForgeProductBilletToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "The list of orders",
                Orders = GetOrders(model)
            });
        }
        /// <summary>
        /// Сохранение заказов в файл-Pdf
        /// </summary>
        /// <param name="model"></param>
        public void SaveForgeProductsToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "The list forgeproducts with billets",
                ForgeProductBillets = GetForgeProductBillet()
            });
        }
        public void SaveStoragesToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "The list of storages",
                ForgeProducts = null,
                Storages = storageLogic.GetList()
            });
        }

        public void SaveStorageBilletsToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "The list billets to storages",
                Orders = null,
                Storages = storageLogic.GetList()
            });
        }
        public void SaveBilletsToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "The list of billets",
                ForgeProductBillets = null,
                StorageBillets = GetStorageBillets()
            });
        }
    }
}