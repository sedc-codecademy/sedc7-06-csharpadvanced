namespace BasicOperators
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product()
        {
            
        }

        public Product(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public static Product operator +(Product p1, Product p2)
        {
            var quantity = p1.Quantity > p2.Quantity ? p1.Quantity : p2.Quantity;
            return new Product($"{p1.Name} + {p2.Name}", quantity, p1.Price + p2.Price);
        }

        public static Product operator -(Product p1, Product p2)
        {
            var quantity = p1.Quantity > p2.Quantity ? p1.Quantity : p2.Quantity;
            return new Product($"{p1.Name} - {p2.Name}", quantity, p1.Price - p2.Price);
        }

        public static Product operator *(Product p1, Product p2)
        {
            var quantity = p1.Quantity > p2.Quantity ? p1.Quantity : p2.Quantity;
            return new Product($"{p1.Name} * {p2.Name}", quantity, p1.Price * p2.Price);
        }

        public static Product operator /(Product p1, Product p2)
        {
            var quantity = p1.Quantity > p2.Quantity ? p1.Quantity : p2.Quantity;
            return new Product($"{p1.Name} / {p2.Name}", quantity, p1.Price / p2.Price);
        }

        public static Product operator %(Product p1, Product p2)
        {
            var quantity = p1.Quantity > p2.Quantity ? p1.Quantity : p2.Quantity;
            return new Product($"{p1.Name} % {p2.Name}", quantity, p1.Price % p2.Price);
        }

        public static Product operator ++(Product p1)
        {
            return new Product($"{p1.Name} ++", p1.Quantity + 1, p1.Price + 1);
        }

        public static Product operator --(Product p1)
        {
            return new Product($"{p1.Name} --", p1.Quantity - 1, p1.Price - 1);
        }

        public static bool operator !(Product p1)
        {
            return p1.Quantity == 0;
        }

        public static Product operator +(Product p1, int a)
        {
            return new Product($"{p1.Name} + {a}", p1.Quantity + a, p1.Price);
        }

        public static bool operator >(Product p1, Product p2)
        {
            return p1.Price * p1.Quantity > p2.Price * p2.Quantity;
        }

        public static bool operator <(Product p1, Product p2)
        {
            return p1.Price * p1.Quantity < p2.Price * p2.Quantity;
        }

        public static bool operator ==(Product p1, Product p2)
        {
            return p1.Name == p2.Name && p1.Price == p2.Price;
        }

        public static bool operator !=(Product p1, Product p2)
        {
            //return p1.Name != p2.Name || p1.Price != p2.Price;
            return !(p1 == p2);
        }
        public static bool operator >=(Product p1, Product p2)
        {
            //return p1.Price * p1.Quantity >= p2.Price * p2.Quantity;
            return !(p1 < p2);
        }
        public static bool operator <=(Product p1, Product p2)
        {
            //return p1.Price * p1.Quantity <= p2.Price * p2.Quantity;
            return !(p1 > p2);
        }

    }
}
