using ForgeShopBusinessLogic.Attributes;
using System.Collections.Generic;
using System.ComponentModel;

namespace ForgeShopBusinessLogic.ViewModels
{
    /// <summary>
    /// Компонент, требуемый для изготовления изделия
    /// </summary>
    public class BilletViewModel : BaseViewModel
    {
        [Column(title: "Заготовка", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string BilletName { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "BilletName"
        };
    }
}