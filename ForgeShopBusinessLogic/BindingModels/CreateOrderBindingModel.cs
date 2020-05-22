using System.Runtime.Serialization;

namespace ForgeShopBusinessLogic.BindingModels
{
    /// <summary>
    /// Данные от клиента, для создания заказа
    /// </summary>
    [DataContract]
    public class CreateOrderBindingModel
    {
        [DataMember]
        public int ForgeProductId { get; set; }
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public decimal Sum { get; set; }
    }
}