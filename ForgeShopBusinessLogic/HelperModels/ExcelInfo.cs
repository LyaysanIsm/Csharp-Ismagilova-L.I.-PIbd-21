using ForgeShopBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopBusinessLogic.HelperModels
{
    class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<(DateTime, List<ReportOrdersViewModel>)> Orders { get; set; }
    }
}