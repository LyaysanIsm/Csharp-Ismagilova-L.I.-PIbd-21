using ForgeShopBusinessLogic.Enums;
using ForgeShopFileImplement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
namespace ForgeShopFileImplement
{
    public class FileDataListSingleton
    {
        private static FileDataListSingleton instance;
        private readonly string BilletFileName = "Billet.xml";
        private readonly string OrderFileName = "Order.xml";
        private readonly string ForgeProductFileName = "ForgeProduct.xml";
        private readonly string ForgeProductBilletFileName = "ForgeProductBillet.xml";
        private readonly string ClientFileName = "Client.xml";
        public List<Billet> Billets { get; set; }
        public List<Order> Orders { get; set; }
        public List<ForgeProduct> ForgeProducts { get; set; }
        public List<ForgeProductBillet> ForgeProductBillets { get; set; }
        public List<Client> Clients { get; set; }
        private FileDataListSingleton()
        {
            Billets = LoadBillets();
            Orders = LoadOrders();
            ForgeProducts = LoadForgeProducts();
            ForgeProductBillets = LoadForgeProductBillets();
            Clients = LoadClients();
        }
        public static FileDataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileDataListSingleton();
            }
            return instance;
        }
        ~FileDataListSingleton()
        {
            SaveBillets();
            SaveOrders();
            SaveForgeProducts();
            SaveForgeProductBillets();
            SaveClients();
        }
        private List<Billet> LoadBillets()
        {
            var list = new List<Billet>();
            if (File.Exists(BilletFileName))
            {
                XDocument xDocument = XDocument.Load(BilletFileName);
                var xElements = xDocument.Root.Elements("Billet").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Billet
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        BilletName = elem.Element("BilletName").Value
                    });
                }
            }
            return list;
        }
        private List<Order> LoadOrders()
        {
            var list = new List<Order>();
            if (File.Exists(OrderFileName))
            {
                XDocument xDocument = XDocument.Load(OrderFileName);
                var xElements = xDocument.Root.Elements("Order").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Order
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ClientId = Convert.ToInt32(elem.Element("ClientId").Value),
                        ForgeProductId = Convert.ToInt32(elem.Element("ForgeProductId").Value),
                        Count = Convert.ToInt32(elem.Element("Count").Value),
                        Sum = Convert.ToDecimal(elem.Element("Sum").Value),
                        Status = (OrderStatus)Enum.Parse(typeof(OrderStatus),
                   elem.Element("Status").Value),
                        DateCreate =
                   Convert.ToDateTime(elem.Element("DateCreate").Value),
                        DateImplement =
                   string.IsNullOrEmpty(elem.Element("DateImplement").Value) ? (DateTime?)null :
                   Convert.ToDateTime(elem.Element("DateImplement").Value),
                    });
                }
            }
            return list;
        }
        private List<ForgeProduct> LoadForgeProducts()
        {
            var list = new List<ForgeProduct>();
            if (File.Exists(ForgeProductFileName))
            {
                XDocument xDocument = XDocument.Load(ForgeProductFileName);
                var xElements = xDocument.Root.Elements("ForgeProduct").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new ForgeProduct
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ForgeProductName = elem.Element("ForgeProductName").Value,
                        Price = Convert.ToDecimal(elem.Element("Price").Value)
                    });
                }
            }
            return list;
        }
        private List<ForgeProductBillet> LoadForgeProductBillets()
        {
            var list = new List<ForgeProductBillet>();
            if (File.Exists(ForgeProductBilletFileName))
            {
                XDocument xDocument = XDocument.Load(ForgeProductBilletFileName);
                var xElements = xDocument.Root.Elements("ForgeProductBillet").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new ForgeProductBillet
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ForgeProductId = Convert.ToInt32(elem.Element("ForgeProductId").Value),
                        BilletId = Convert.ToInt32(elem.Element("BilletId").Value),
                        Count = Convert.ToInt32(elem.Element("Count").Value)
                    });
                }
            }
            return list;
        }
        private List<Client> LoadClients()
        {
            var list = new List<Client>();
            if (File.Exists(ClientFileName))
            {
                XDocument xDocument = XDocument.Load(ClientFileName);
                var xElements = xDocument.Root.Elements("Client").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Client
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ClientFIO = elem.Element("FIO").Value,
                        Email = elem.Element("Email").Value,
                        Password = elem.Element("Password").Value
                    });
                }
            }
            return list;
        }
        private void SaveBillets()
        {
            if (Billets != null)
            {
                var xElement = new XElement("Billets");
                foreach (var billet in Billets)
                {
                    xElement.Add(new XElement("Billet",
                    new XAttribute("Id", billet.Id),
                    new XElement("BilletName", billet.BilletName)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(BilletFileName);
            }
        }
        private void SaveOrders()
        {
            if (Orders != null)
            {
                var xElement = new XElement("Orders");
                foreach (var order in Orders)
                {
                    xElement.Add(new XElement("Order",
                    new XAttribute("Id", order.Id),
                    new XElement("ClientId", order.ClientId),
                    new XElement("ForgeProductId", order.ForgeProductId),
                    new XElement("Count", order.Count),
                    new XElement("Sum", order.Sum),
                    new XElement("Status", order.Status),
                    new XElement("DateCreate", order.DateCreate),
                    new XElement("DateImplement", order.DateImplement)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(OrderFileName);
            }
        }
        private void SaveForgeProducts()
        {
            if (ForgeProducts != null)
            {
                var xElement = new XElement("ForgeProducts");
                foreach (var forgeproduct in ForgeProducts)
                {
                    xElement.Add(new XElement("ForgeProduct",
                    new XAttribute("Id", forgeproduct.Id),
                    new XElement("ForgeProductName", forgeproduct.ForgeProductName),
                    new XElement("Price", forgeproduct.Price)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ForgeProductFileName);
            }
        }
        private void SaveForgeProductBillets()
        {
            if (ForgeProductBillets != null)
            {
                var xElement = new XElement("ForgeProductBillets");
                foreach (var forgeproductBillet in ForgeProductBillets)
                {
                    xElement.Add(new XElement("ForgeProductBillet",
                    new XAttribute("Id", forgeproductBillet.Id),
                    new XElement("ForgeProductId", forgeproductBillet.ForgeProductId),
                    new XElement("BilletId", forgeproductBillet.BilletId),
                    new XElement("Count", forgeproductBillet.Count)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ForgeProductBilletFileName);
            }
        }
        private void SaveClients()
        {
            if (Clients != null)
            {
                var xElement = new XElement("Clients");
                foreach (var client in Clients)
                {
                    xElement.Add(new XElement("Client",
                    new XAttribute("Id", client.Id),
                    new XElement("FIO", client.ClientFIO),
                    new XElement("Email", client.Email),
                    new XElement("Password", client.Password)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ClientFileName);
            }
        }
    }
}