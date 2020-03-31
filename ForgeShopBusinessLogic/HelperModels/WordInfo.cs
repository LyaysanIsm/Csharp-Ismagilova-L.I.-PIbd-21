using ForgeShopBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopBusinessLogic.HelperModels
{
    class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ForgeProductViewModel> ForgeProducts { get; set; }
    }
}