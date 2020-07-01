using System.ComponentModel;

namespace ForgeShopBusinessLogic.ViewModels
{
    /// <summary>
    /// Компонент, требуемый для изготовления изделия
    /// </summary>
    public class BilletViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название заготовки")]
        public string BilletName { get; set; }
    }
}