using System.Collections.Generic;

namespace NestedClassesRefactor.MyClasses
{
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
    }
}