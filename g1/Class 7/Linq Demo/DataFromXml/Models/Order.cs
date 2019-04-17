using System;
using System.Xml.Serialization;

namespace DataFromXml.Models
{
    public class Order
    {
        [XmlElement("OrderID")]
        public int OrderId { get; set; }
        [XmlElement("CustomerID")]
        public string CustomerId { get; set; }
        [XmlElement("EmployeeID")]
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public double? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public void PrintOrder()
        {
            Console.WriteLine($"{OrderId} | {CustomerId} | {EmployeeId} | {OrderDate} | " +
                $"{RequiredDate} | {ShippedDate} | {ShipVia} | {Freight} | " +
                $"{ShipName} | {ShipAddress} | {ShipCity} | {ShipPostalCode} | {ShipCountry}");
        }
    }
}
