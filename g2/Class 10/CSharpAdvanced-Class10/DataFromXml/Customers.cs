using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace DataFromXml
{
    public class Customer
    {
        #region Properties
        public string CustomerID { get; set; }
	    public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        #endregion
        #region Constructors
        public Customer() { }
        #endregion
        #region Methods
        public static List<Customer> GetAllCustomers()
        {
            string currentPath = null;
            var directory = new DirectoryInfo(
            currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any()) {
                directory = directory.Parent;
            }
            string filePath = directory.FullName + @"\Customers.xml";
            
            XDocument xDoc = XDocument.Load(filePath);
            IEnumerable<XElement> customers = xDoc.Root.Elements();
            List<Customer> customerList = new List<Customer>();
            foreach (var cust in customers)
            {
                XElement found;
                Customer c = new Customer();

                found = cust.Element("CustomerID");
                c.CustomerID = cust.Element("CustomerID").Value;

                found = cust.Element("CompanyName");
                c.CompanyName = cust.Element("CompanyName").Value;

                found = cust.Element("ContactName");
                c.ContactName = found != null ? cust.Element("ContactName").Value : string.Empty;

                found = cust.Element("ContactTitle");
                c.ContactTitle = found != null ? cust.Element("ContactTitle").Value : string.Empty;

                found = cust.Element("Address");
                c.Address = found != null ? cust.Element("Address").Value : string.Empty;

                found = cust.Element("City");
                c.City = found != null ? cust.Element("City").Value : string.Empty;

                found = cust.Element("PostalCode");
                c.PostalCode = found != null ? cust.Element("PostalCode").Value : string.Empty;

                found = cust.Element("Country");
                c.Country = found != null ? cust.Element("Country").Value : string.Empty;

                found = cust.Element("Phone");
                c.Phone = found != null ? cust.Element("Phone").Value : string.Empty;

                found = cust.Element("Fax"); 
                c.Phone = found != null ? cust.Element("Fax").Value : string.Empty;

                customerList.Add(c);
            }
            return customerList;
        }         
        public static void PrintCustomerHeader()
        {
            Console.WriteLine($"ID | Company | Contact | Title | " +
                "Address | City | PostalCode | Country | " +
                "Phone | Fax");
        }
        public void PrintCustomer(Customer p)
        {
            Console.WriteLine($"{p.CustomerID} | {p.CompanyName} | {p.ContactName} | {p.ContactTitle} | " +
                $"{p.Address} | {p.City} | {p.PostalCode} | {p.Country} | " +
                $"{p.Phone} | {p.Fax}");
        }
        public static void PrintCustomers(IEnumerable<Customer> customers) {
            PrintCustomerHeader();
            foreach (var item in customers) {
                item.PrintCustomer(item);
            }
        }
        #endregion
    }
}
