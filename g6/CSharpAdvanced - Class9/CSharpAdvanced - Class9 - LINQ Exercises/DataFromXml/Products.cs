using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace DataFromXml
{
    public class Product
    {        
        #region Properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public double? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        #endregion
        #region Constructor
        public Product() { }
        public Product(int id, string prodName, int? supplierId, int? categId,
            string quanittyPerUnit, double? unitPrice, int? unitsInStock, int? unitsOnOrder,
            int? reorderLevel, bool disontinued)
        {
            this.ProductID = id; this.ProductName = prodName; this.SupplierID = supplierId;
            this.CategoryID = categId; this.QuantityPerUnit = quanittyPerUnit;
            this.UnitPrice = unitPrice; this.UnitsInStock = unitsInStock;
            this.UnitsOnOrder = unitsOnOrder; this.ReorderLevel = reorderLevel;
            this.Discontinued = disontinued;
        }
        #endregion
        #region Methods
        public static List<Product> GetAllProducts()
        {
            string currentPath = null;
            var directory = new DirectoryInfo(
            currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any()) {
                directory = directory.Parent;
            }
            string filePath = directory.FullName + @"\Products.xml";

            //XDocument xDoc = XDocument.Load(@"C:\Temp\Products.xml");
            XDocument xDoc = XDocument.Load(filePath);
            IEnumerable<XElement> products = xDoc.Root.Elements();
            List<Product> prodList = new List<Product>();
            foreach(var p in products)
            {
                Product prod = new Product();
                int intVal;
                int.TryParse(p.Element("ProductID").Value, out intVal);
                prod.ProductID = intVal;

                prod.ProductName = p.Element("ProductName").Value;

                int.TryParse(p.Element("SupplierID").Value, out intVal);
                prod.SupplierID = intVal;

                int.TryParse(p.Element("CategoryID").Value, out intVal);
                prod.CategoryID = intVal;

                prod.QuantityPerUnit = p.Element("QuantityPerUnit").Value;

                double dblVal;
                double.TryParse(p.Element("UnitPrice").Value, out dblVal);
                prod.UnitPrice = dblVal;

                int.TryParse(p.Element("UnitsInStock").Value, out intVal);
                prod.UnitsInStock = intVal;

                int.TryParse(p.Element("UnitsOnOrder").Value, out intVal);
                prod.UnitsOnOrder = intVal;
                
                int.TryParse(p.Element("ReorderLevel").Value, out intVal);
                prod.ReorderLevel = intVal;

                bool bit;
                bool.TryParse(p.Element("Discontinued").Value, out bit);
                prod.Discontinued = bit;
                                
                prodList.Add(prod);
            }
            return prodList;
        }

        public static void PrintProductHeader()
        {
            Console.WriteLine($"ID | ProductName | SupplID | CategID | " +
                "QntyPerUnit | UnitPrice | UnitsInStock | UnitsOnOrder | " +
                "Level | Discn");
        }
        public void PrintProduct(Product p)
        {
            Console.WriteLine($"{p.ProductID} | {p.ProductName} | {p.SupplierID} | {p.CategoryID} | " +
                $"{p.QuantityPerUnit} | {p.UnitPrice} | {p.UnitsInStock} | {p.UnitsOnOrder} | " +
                $"{p.ReorderLevel} | {p.Discontinued}");
        }
        public static void PrintProducts(IEnumerable<Product> products) {
            PrintProductHeader();
            foreach (var item in products) {
                item.PrintProduct(item);
            }
        }

        #endregion
    }
}
