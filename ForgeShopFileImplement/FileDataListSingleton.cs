﻿using ForgeShopBusinessLogic.Enums;
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
        private readonly string ImplementerFileName = "Implementer.xml";
        private readonly string MessageInfoFileName = "MessageInfo.xml";

        public List<Billet> Billets { get; set; }
        public List<Order> Orders { get; set; }
        public List<ForgeProduct> ForgeProducts { get; set; }
        public List<ForgeProductBillet> ForgeProductBillets { get; set; }
        public List<Client> Clients { get; set; }
        public List<Implementer> Implementers { get; set; }
        public List<MessageInfo> MessageInfoes { get; set; }

        private FileDataListSingleton()
        {
            Billets = LoadBillets();
            Orders = LoadOrders();
            ForgeProducts = LoadForgeProducts();
            ForgeProductBillets = LoadForgeProductBillets();
            Clients = LoadClients();
            Implementers = LoadImplementers();
            MessageInfoes = LoadMessageInfoes();
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
            SaveImplementers();
            SaveMessageInfoes();
        }
        private List<Implementer> LoadImplementers()
        {
            var list = new List<Implementer>();
            if (File.Exists(ImplementerFileName))
            {
                XDocument xDocument = XDocument.Load(ImplementerFileName);
                var xElements = xDocument.Root.Elements("Implementer").ToList();

                foreach (var elem in xElements)
                {
                    list.Add(new Implementer
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ImplementerFIO = elem.Element("ImplementerFIO").Value,
                        WorkingTime = Convert.ToInt32(elem.Element("WorkingTime").Value),
                        PauseTime = Convert.ToInt32(elem.Element("PauseTime").Value)
                    });
                }
            }
            return list;
        }
        private List<MessageInfo> LoadMessageInfoes()
        {
            var list = new List<MessageInfo>();
            if (File.Exists(MessageInfoFileName))
            {
                XDocument xDocument = XDocument.Load(MessageInfoFileName);
                var xElements = xDocument.Root.Elements("MessageInfo").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new MessageInfo
                    {
                        MessageId = elem.Attribute("MessageId").Value,
                        ClientId = Convert.ToInt32(elem.Element("ClientId").Value),
                        SenderName = elem.Element("SenderName").Value,
                        DateDelivery = Convert.ToDateTime(elem.Element("DateDelivery").Value),
                        Subject = elem.Element("Subject").Value,
                        Body = elem.Element("Body").Value
                    });
                }
            }
            return list;
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
                        ImplementerId = Convert.ToInt32(elem.Attribute("ImplementerId").Value),
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
        private void SaveImplementers()
        {
            if (Implementers != null)
            {
                var xElement = new XElement("Implementers");
                foreach (var implementer in Implementers)
                {
                    xElement.Add(new XElement("Implementer",
                    new XAttribute("Id", implementer.Id),
                    new XElement("ImplementerFIO", implementer.ImplementerFIO),
                    new XElement("WorkingTime", implementer.WorkingTime),
                    new XElement("PauseTime", implementer.PauseTime)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ImplementerFileName);
            }
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
                        ClientFIO = elem.Element("ClientFIO").Value,
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
                    new XElement("ImplementerId", order.ImplementerId),
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
        private void SaveMessageInfoes()
        {
            if (MessageInfoes != null)
            {
                var xElement = new XElement("MessageInfoes");
                foreach (var messageInfo in MessageInfoes)
                {
                    xElement.Add(new XElement("MessageInfo",
                    new XAttribute("Id", messageInfo.MessageId),
                    new XElement("ClientId", messageInfo.ClientId),
                    new XElement("SenderName", messageInfo.SenderName),
                    new XElement("DateDelivery", messageInfo.DateDelivery),
                    new XElement("Subject", messageInfo.Subject),
                    new XElement("Body", messageInfo.Body)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(MessageInfoFileName);
            }
        }
    }
}