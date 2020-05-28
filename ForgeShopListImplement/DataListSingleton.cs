using ForgeShopListImplement.Models;
using System.Collections.Generic;

namespace ForgeShopListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;
        public List<Billet> Billets { get; set; }
        public List<Order> Orders { get; set; }
        public List<ForgeProduct> ForgeProducts { get; set; }
        public List<ForgeProductBillet> ForgeProductBillets { get; set; }
        public List<Storage> Storages { get; set; }
        public List<StorageBillet> StorageBillets { get; set; }
        public List<Client> Clients { get; set; }
        private DataListSingleton()
        {
            Billets = new List<Billet>();
            Orders = new List<Order>();
            ForgeProducts = new List<ForgeProduct>();
            ForgeProductBillets = new List<ForgeProductBillet>();
            Storages = new List<Storage>();
            StorageBillets = new List<StorageBillet>();
            Clients = new List<Client>();
        }
        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}