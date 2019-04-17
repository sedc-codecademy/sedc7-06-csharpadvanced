using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using DataFromXml.Models;

namespace DataFromXml.Services
{
    public static class ProductService
    {
        public static List<Product> GetAllProducts()
        {
            using (var reader = new StreamReader("Data\\Products.xml"))
            {
                XmlSerializer serializer = 
                    new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("Products"));
                var products = (List<Product>)serializer.Deserialize(reader);
                return products;
            }
        }
        
        public static void PrintProductHeader()
        {
            Console.WriteLine($"ID | ProductName | SupplID | CategID | " +
                              "QntyPerUnit | UnitPrice | UnitsInStock | UnitsOnOrder | " +
                              "Level | Discn");
        }

        public static void PrintProducts(IEnumerable<Product> products)
        {
            PrintProductHeader();
            foreach (var item in products)
            {
                item.PrintProduct();
            }
        }
    }
}
