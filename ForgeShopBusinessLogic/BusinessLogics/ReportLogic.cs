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
        public ReportLogic(IForgeProductLogic forgeproductLogic, IOrderLogic orderLLogic)
        {
            this.forgeproductLogic = forgeproductLogic;
            this.orderLogic = orderLLogic;
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
        /// <summary>
        /// Получение списка заказов за определенный период
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<(DateTime, List<ReportOrdersViewModel>)> GetOrders(ReportBindingModel model)
        {
            List<(DateTime, List<ReportOrdersViewModel>)> list = new List<(DateTime, List<ReportOrdersViewModel>)>();
            var orders = orderLogic.Read(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            })
             .Select(x => new ReportOrdersViewModel
             {
                 DateCreate = x.DateCreate,
                 ForgeProductName = x.ForgeProductName,
                 Count = x.Count,
                 Sum = x.Sum,
                 Status = x.Status
             });
            List<DateTime> dates = new List<DateTime>();
            foreach (var order in orders)
            {
                if (!dates.Contains(order.DateCreate.Date))
                {
                    dates.Add(order.DateCreate.Date);
                }
            }
            foreach (var date in dates)
            {
                (DateTime, List<ReportOrdersViewModel>) record;
                record.Item2 = new List<ReportOrdersViewModel>();

                record.Item1 = date;

                foreach (var order in orders.Where(rec => rec.DateCreate.Date == date))
                {
                    record.Item2.Add(order);
                }

                list.Add(record);
            }
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
    }
}