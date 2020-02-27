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
        private DataListSingleton()
        {
            Billets = new List<Billet>();
            Orders = new List<Order>();
            ForgeProducts = new List<ForgeProduct>();
            ForgeProductBillets = new List<ForgeProductBillet>();
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