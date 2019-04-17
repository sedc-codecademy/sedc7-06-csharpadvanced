using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using DataFromXml.Models;

namespace DataFromXml.Services
{
    public static class OrderService
    {
        public static List<Order> GetAllOrders()
        {
            using (var reader = new StreamReader("Data\\Orders.xml"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Order>), new XmlRootAttribute("Orders"));
                var orders = (List<Order>)deserializer.Deserialize(reader);
                return orders;
            }
        }

        public static void PrintOrderHeader()
        {
            Console.WriteLine($"ID | CustomerID | EmployeeID | OrderDate | " +
                              "RequiredDate | ShippedDate | ShipVia | Freight | " +
                              "ShipName | ShipAddress | ShipCity | ShipPostalCode | ShipCountry");
        }

        public static void PrintOrders(IEnumerable<Order> orders)
        {
            PrintOrderHeader();
            foreach (var item in orders)
            {
                item.PrintOrder();
            }
        }
    }
}
