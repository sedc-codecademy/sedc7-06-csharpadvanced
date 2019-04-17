using System.Collections.Generic;
using DataFromXml;

namespace Aggregate_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Find all orders with 'VINET' Customer ID and print information for Count and Freight

            //Print the count of all orders per different Customer ID

            //Print the count and total Freight of all orders with 'VINET' Customer ID

            //Print the order with 'VINET' Customer ID identified by the minimal Freight 

            //Print all orders per different Ship Country identified by the maximum Freight 

            //Print the average Freight (with two decimals) for all orders
        }
    }
}