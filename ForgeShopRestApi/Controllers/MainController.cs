using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.BusinessLogics;
using ForgeShopBusinessLogic.Interfaces;
using ForgeShopBusinessLogic.ViewModels;
using ForgeShopRestApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForgeShopRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IOrderLogic _order;
        private readonly IForgeProductLogic _forgeproduct;
        private readonly MainLogic _main;
        public MainController(IOrderLogic order, IForgeProductLogic forgeproduct, MainLogic main)
        {
            _order = order;
            _forgeproduct = forgeproduct;
            _main = main;
        }
        [HttpGet]
        public List<ForgeProductModel> GetForgeProductList() => _forgeproduct.Read(null)?.Select(rec =>
       Convert(rec)).ToList();
        [HttpGet]
        public ForgeProductModel GetForgeProduct(int forgeproductId) => Convert(_forgeproduct.Read(new ForgeProductBindingModel
        {
            Id = forgeproductId
        })?[0]);
        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new OrderBindingModel
        {
            ClientId = clientId
        });
        [HttpPost]
        public void CreateOrder(CreateOrderBindingModel model) =>
       _main.CreateOrder(model);
        private ForgeProductModel Convert(ForgeProductViewModel model)
        {
            if (model == null) return null;
            return new ForgeProductModel
            {
                Id = model.Id,
                ForgeProductName = model.ForgeProductName,
                Price = model.Price
            };
        }
    }
}