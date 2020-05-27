using ForgeShopBusinessLogic.BindingModels;
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
    public class StorageController : ControllerBase
    {
        private readonly IStorageLogic _storage;
        private readonly IBilletLogic _Billet;

        public StorageController(IStorageLogic storage, IBilletLogic Billet)
        {
            _storage = storage;
            _Billet = Billet;
        }

        [HttpGet]
        public List<StorageModel> GetStoragesList() => _storage.GetList()?.Select(rec => Convert(rec)).ToList();
        [HttpGet]
        public List<BilletViewModel> GetBilletsList() => _Billet.Read(null)?.ToList();
        [HttpGet]
        public StorageModel GetStorage(int StorageId) => Convert(_storage.GetElement(StorageId));
        [HttpPost]
        public void CreateOrUpdateStorage(StorageBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _storage.UpdElement(model);
            }
            else
            {
                _storage.AddElement(model);
            }
        }
        [HttpPost]
        public void DeleteStorage(StorageBindingModel model) => _storage.DelElement(model);
        [HttpPost]
        public void FillStorage(StorageBilletBindingModel model) => _storage.FillStorage(model);
        private StorageModel Convert(StorageViewModel model)
        {
            if (model == null) return null;
            return new StorageModel
            {
                Id = model.Id,
                StorageName = model.StorageName
            };
        }
    }
}