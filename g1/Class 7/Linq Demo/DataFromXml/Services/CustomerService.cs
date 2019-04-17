using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using DataFromXml.Models;

namespace DataFromXml.Services
{
    public static class CustomerService
    {
        public static List<Customer> GetAllCustomers()
        {
            using (var reader = new StreamReader("Data\\Customers.xml"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("Customers"));
                var customers = (List<Customer>)deserializer.Deserialize(reader);
                return customers;
            }
        }

        public static void PrintCustomerHeader()
        {
            Console.WriteLine($"ID | Company | Contact | Title | " +
                              "Address | City | PostalCode | Country | " +
                              "Phone | Fax");
        }

        public static void PrintCustomers(IEnumerable<Customer> customers)
        {
            PrintCustomerHeader();
            foreach (var item in customers)
            {
                item.PrintCustomer();
            }
        }
    }
}
