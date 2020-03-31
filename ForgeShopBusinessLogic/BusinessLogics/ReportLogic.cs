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
        private readonly IBilletLogic billetLogic;
        private readonly IForgeProductLogic forgeproductLogic;
        private readonly IOrderLogic orderLogic;
        public ReportLogic(IForgeProductLogic forgeproductLogic, IBilletLogic billetLogic,
       IOrderLogic orderLLogic)
        {
            this.forgeproductLogic = forgeproductLogic;
            this.billetLogic = billetLogic;
            this.orderLogic = orderLLogic;
        }
        /// <summary>
        /// Получение списка компонент с указанием, в каких изделиях используются
        /// </summary>
        /// <returns></returns>
        public List<ReportForgeProductBilletViewModel> GetForgeProductBillet()
        {
            var billets = billetLogic.Read(null);
            var forgeproducts = forgeproductLogic.Read(null);
            var list = new List<ReportForgeProductBilletViewModel>();
            foreach (var billet in billets)
            {
                foreach (var forgeproduct in forgeproducts)
                {
                    if (forgeproduct.ForgeProductBillets.ContainsKey(billet.Id))
                    {
                        var record = new ReportForgeProductBilletViewModel
                        {
                            ForgeProductName = forgeproduct.ForgeProductName,
                            BilletName = billet.BilletName,
                            Count = forgeproduct.ForgeProductBillets[billet.Id].Item2
                        };
                        list.Add(record);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Получение списка заказов за определенный период
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return orderLogic.Read(new OrderBindingModel
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
            })
           .ToList();
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
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
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