using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeShopBusinessLogic.BindingModels
{
    /// <summary>
    /// Компонент, требуемый для изготовления изделия
    /// </summary>
    public class BilletBindingModel
    {
        public int? Id { get; set; }
        public string BilletName { get; set; }
    }
}