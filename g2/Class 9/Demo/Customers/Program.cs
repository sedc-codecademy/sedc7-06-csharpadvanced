using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public class Customer : IComparable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int MonthlySpend { get; set; }

        public Customer() { }
        public Customer(string name, string address, string city, int monthlySpend)
        {
            this.Name = name; this.Address = address; this.City = city; this.MonthlySpend = monthlySpend;
        }
        public void PrintCustomer()
        {
            Console.WriteLine($"Customer: {Name}, {Address}, {City}, {MonthlySpend}");
        }

        public int CompareTo(Object o)
        {
            Customer c = (Customer)o;
            return String.Compare(this.Name, c.Name);
        }
    }
    public class CustomerMonthlySpendComparer : IComparer<Customer>
    {
        public int Compare(Customer c1, Customer c2)
        {
            return c1.MonthlySpend - c2.MonthlySpend;
        }
    }
    public class CustomerCityComparer : IComparer<Customer>
    {
        public int Compare(Customer c1, Customer c2)
        {
            return string.Compare(c1.City, c2.City);
        }
    }
    class Program
    {
        #region Info
        /*
        - To provide sorting or comparison capability for custom objects
            either or both of these interfaces (IComparable, IComaprer) must be implemented
        - IComparable - provide a default sort order for objects. If you have an array of objects of your type,
            and you call the Sort method on that array, IComparable provides the comparison of objects during the sort
            When you implement the IComparable interface, you must implement the CompareTo method, as follows
        - IComparer - provide additional comparison mechanisms. If you may want to provide ordering of your class
            on several fields or properties, ascending and descending order on the same field, or both
        */
        #endregion
        //https://support.microsoft.com/en-gb/help/320727/how-to-use-the-icomparable-and-icomparer-interfaces-in-visual-c
        static void Main(string[] args)
        {
            Customer c1 = new Customer("igor", "partizanska 95", "Skopje", 30000);
            Customer c2 = new Customer("dejan", "roza luxemburg 1", "Skopje", 25000);
            Customer c3 = new Customer("ivan", "partizanska 95", "Strumica", 29000);
            Customer c4 = new Customer("petar", "vodjanska 95", "Bitola", 35000);
            Customer c5 = new Customer("marko", "helsinshka", "Veles", 21000);

            Customer[] customers = new Customer[] { c1, c2, c3, c4, c5 };
            Console.WriteLine("\n----------- Customers -----------");
            foreach (var c in customers)
            {
                c.PrintCustomer();
            }

            Console.WriteLine("\n----------- Customers sorted by Name(Default) -----------");
            Array.Sort(customers); //fails if IComparable is not implemented
            foreach (var c in customers)
            {
                c.PrintCustomer();
            }

            Console.WriteLine("\n----------- Customers sorted by MonthlySpend -----------");
            Array.Sort(customers, new CustomerMonthlySpendComparer());
            foreach (var c in customers)
            {
                c.PrintCustomer();
            }

            Console.WriteLine("\n----------- Customers sorted by City -----------");
            Array.Sort(customers, new CustomerCityComparer());
            foreach (var c in customers)
            {
                c.PrintCustomer();
            }

            Console.ReadLine();
        }
    }
}
