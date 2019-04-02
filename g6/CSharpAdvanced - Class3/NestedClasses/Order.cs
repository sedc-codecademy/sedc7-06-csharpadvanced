using System.Collections.Generic;

namespace NestedClasses
{
    /// <summary>
    /// Nested classes are created within the code block of other classes.
    /// They behave the same way as the other classes and by default they are 
    /// private. In real-world example nested classes are rarely used, because they
    /// look confusing a bit and benefits from nested classes can be achieved on 
    /// many other ways. It is good to know what is a nested class, to recognize it 
    /// once you see it in the code. But sincerely I wouldn't spent to much time 
    /// on excercising them and would spent that time on mastering interfaces,extension methods,
    /// static classes and methods. :)
    /// </summary>
    public class Order
    {
        private List<OrderLine> _orderLines = new List<OrderLine>();
        public void AddOrderLine(string product, int quantity, double price)
        {
            OrderLine line = new OrderLine();
            line.ProductName = product;
            line.Quantity = quantity;
            line.Price = price;
            _orderLines.Add(line);
        }

        public double OrderTotal()
        {
            double total = 0;
            foreach (var orderLine in _orderLines)
            {
                total += orderLine.OrderLineTotal();
            }
            return total;
        }

       /// <summary>
       /// 
       /// </summary>
        private class OrderLine
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }
            public double OrderLineTotal()
            {
                return Price * Quantity;
            }
        }
    }
}