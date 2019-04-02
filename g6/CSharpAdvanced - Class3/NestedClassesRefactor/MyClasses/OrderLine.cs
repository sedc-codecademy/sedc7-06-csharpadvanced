namespace NestedClassesRefactor.MyClasses
{
    //this is the nested class
    internal class OrderLine
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