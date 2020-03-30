using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopBusinessLogic.ViewModels
{
    public class ReportForgeProductBilletViewModel
    {
        public string BilletName { get; set; }
        public int TotalCount { get; set; }
        public List<Tuple<string, int>> ForgeProducts { get; set; }
    }
}