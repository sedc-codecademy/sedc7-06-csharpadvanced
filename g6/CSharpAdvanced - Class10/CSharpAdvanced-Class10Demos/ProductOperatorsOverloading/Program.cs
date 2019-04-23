namespace ProductOperatorsOverloading
{
    class Program
    {
        public class Product
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            public Product()
            {

            }

            #region Operators Overloading
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
            #endregion
        }

        static void Main(string[] args)
        {
            Product p1 = new Product("HDD", 20, 50);
            Product p2 = new Product("CPU", 30, 20);
            Product p11 = new Product("Speaker", 50, 10);

            var p3 = p1 + p2;
            var p4 = p1 - p2;
            var p5 = p1 * p2;
            var p6 = p1 / p2;
            var p7 = p1 % p2;
            p1++;
            p2--;

            var p10 = p11 + 40;

            bool t = p1 > p2;
            bool t1 = p1 == p2;

            if (p1 == p2)
            {
                var p12 = p1 + p2.Quantity;
            }
        }
    }
}