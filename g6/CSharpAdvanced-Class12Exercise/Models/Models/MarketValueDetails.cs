namespace Models.Models
{
    public class MarketValueDetails
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public MarketValueDetails()
        {

        }

        public MarketValueDetails(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
    }
}
