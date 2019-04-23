using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace DataFromXml
{
    public class Order
    {
        #region Properties
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public Nullable<DateTime> RequiredDate { get; set; }
        public Nullable<DateTime> ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public Nullable<double> Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        #endregion
        #region Constructors
        public Order() { }
        #endregion
        #region Methods
        public static void PrintOrderHeader()
        {
            Console.WriteLine($"ID | CustomerID | EmployeeID | OrderDate | " +
                "RequiredDate | ShippedDate | ShipVia | Freight | " +
                "ShipName | ShipAddress | ShipCity | ShipPostalCode | ShipCountry");
        }
        public void PrintOrder(Order p)
        {
            Console.WriteLine($"{p.OrderID} | {p.CustomerID} | {p.EmployeeID} | {p.OrderDate} | " +
                $"{p.RequiredDate} | {p.ShippedDate} | {p.ShipVia} | {p.Freight} | " +
                $"{p.ShipName} | {p.ShipAddress} | {p.ShipCity} | {p.ShipPostalCode} | {p.ShipCountry}");
        }
        public static void PrintOrders(IEnumerable<Order> orders)
        {
            PrintOrderHeader();
            foreach (var item in orders)
            {
                item.PrintOrder(item);
            }
        }

        public static List<Order> GetAllOrders()
        {
            string currentPath = null;
            var directory = new DirectoryInfo(
            currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            string filePath = directory.FullName + @"\Orders.xml";

            List<Order> orderList = new List<Order>();
            //XDocument xDoc = XDocument.Load(@"C:\Temp\Orders.xml");
            XDocument xDoc = XDocument.Load(filePath);
            IEnumerable<XElement> orders = xDoc.Root.Elements();
            foreach (var o in orders)
            {
                try
                {
                    Order ord = new Order();
                    XElement found;
                    int intVal;
                    int.TryParse(o.Element("OrderID").Value, out intVal);
                    found = o.Element("OrderID");
                    ord.OrderID = found != null ? intVal : intVal;

                    found = o.Element("CustomerID");
                    ord.CustomerID = found != null ? o.Element("CustomerID").Value : null;

                    found = o.Element("EmployeeID");

                    int.TryParse(o.Element("EmployeeID").Value, out intVal);
                    ord.EmployeeID = found != null ? intVal : intVal;

                    found = o.Element("OrderDate");
                    DateTime dt;
                    DateTime.TryParse(o.Element("OrderDate").Value, out dt);
                    ord.OrderDate = found != null ? dt : dt;

                    found = o.Element("RequiredDate");
                    DateTime.TryParse(o.Element("RequiredDate").Value, out dt);
                    ord.RequiredDate = found != null ? dt : dt;

                    found = o.Element("ShippedDate");
                    DateTime.TryParse(o.Element("ShippedDate").Value, out dt);
                    ord.ShippedDate = found != null ? dt : dt;

                    found = o.Element("ShipVia");
                    int.TryParse(o.Element("ShipVia").Value, out intVal);
                    ord.ShipVia = found != null ? intVal : intVal;

                    double dblVal;
                    found = o.Element("Freight");
                    double.TryParse(o.Element("Freight").Value, out dblVal);
                    ord.Freight = found != null ? dblVal : dblVal;

                    found = o.Element("ShipName");
                    ord.ShipName = found == null ? o.Element("ShipName").Value : null;

                    found = o.Element("ShipAddress");
                    ord.ShipAddress = found != null ? o.Element("ShipAddress").Value : null;

                    found = o.Element("ShipCity");
                    ord.ShipCity = found != null ? o.Element("ShipCity").Value : null;

                    found = o.Element("ShipPostalCode");
                    ord.ShipPostalCode = found != null ? o.Element("ShipPostalCode").Value : string.Empty;

                    found = o.Element("ShipCountry");
                    ord.ShipCountry = found != null ? o.Element("ShipCountry").Value : null;

                    orderList.Add(ord);
                }
                catch { }

            }
            return orderList;
        }
        #endregion
    }
}
