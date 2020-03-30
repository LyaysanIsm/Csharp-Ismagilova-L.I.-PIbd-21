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
                var record = new ReportForgeProductBilletViewModel
                {
                    BilletName = billet.BilletName,
                    ForgeProducts = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var forgeproduct in forgeproducts)
                {
                    if (forgeproduct.ForgeProductBillets.ContainsKey(billet.Id))
                    {
                        record.ForgeProducts.Add(new Tuple<string, int>(forgeproduct.ForgeProductName,
                       forgeproduct.ForgeProductBillets[billet.Id].Item2));
                        record.TotalCount +=
                       forgeproduct.ForgeProductBillets[billet.Id].Item2;
                    }
                }
                list.Add(record);
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
        /// Сохранение компонент в файл-Word
        /// </summary>
        /// <param name="model"></param>
        public void SaveBilletsToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список компонент",
                Billets = billetLogic.Read(null)
            });
        }
        /// <summary>
        /// Сохранение компонент с указаеним продуктов в файл-Excel
        /// </summary>
        /// <param name="model"></param>
        public void SaveForgeProductBilletToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список компонент",
                ForgeProductBillets = GetForgeProductBillet()
            });
        }
        /// <summary>
        /// Сохранение заказов в файл-Pdf
        /// </summary>
        /// <param name="model"></param>
        public void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Orders = GetOrders(model)
            });
        }
    }
}