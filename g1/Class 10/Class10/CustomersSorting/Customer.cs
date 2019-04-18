using System;

namespace CustomersSorting {
    public class Customer : IComparable<Customer> 
    { 
        public string Name { get; set; } 
        public string Address { get; set; }
        public string City { get; set; }
        public int MonthlySpend { get; set; }

        public Customer() { }
        public Customer(string name, string address, string city, int monthlySpend) {
            Name = name; Address = address; City = city; MonthlySpend = monthlySpend;
        }
        public void PrintCustomer() {
            Console.WriteLine($"Customer: {Name}, {Address}, {City}, {MonthlySpend}");
        }
        public int CompareTo(Customer c) {
            return MonthlySpend.CompareTo(c.MonthlySpend);
        }
    }
}
