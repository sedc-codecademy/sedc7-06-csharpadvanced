namespace Comparer
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Country { get; set; }

        public Product()
        {

        }

        public Product(string name, int quantity, double price, string country)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Country = country;
        }
    }
}