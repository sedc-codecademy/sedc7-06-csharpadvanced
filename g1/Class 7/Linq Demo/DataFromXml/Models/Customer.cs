using System;
using System.Xml.Serialization;

namespace DataFromXml.Models
{
    public class Customer
    {
        [XmlElement("CustomerID")]
        public string CustomerId { get; set; }
	    public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        
        public void PrintCustomer()
        {
            Console.WriteLine($"{CustomerId} | {CompanyName} | {ContactName} | {ContactTitle} | " +
                $"{Address} | {City} | {PostalCode} | {Country} | " +
                $"{Phone} | {Fax}");
        }
    }
}
