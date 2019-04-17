using System;
using System.Xml.Serialization;

namespace DataFromXml.Models
{
    public class Product
    {
        [XmlElement("ProductID")]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        [XmlElement("SupplierID")]
        public int? SupplierId { get; set; }
        [XmlElement("CategoryID")]
        public int? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public double? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        
        public void PrintProduct()
        {
            Console.WriteLine($"{ProductId} | {ProductName} | {SupplierId} | {CategoryId} | " +
                $"{QuantityPerUnit} | {UnitPrice} | {UnitsInStock} | {UnitsOnOrder} | " +
                $"{ReorderLevel} | {Discontinued}");
        }
    }
}
