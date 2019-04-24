using Models.Enums;
using Models.Models;
using System.Collections.Generic;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public Channel Channel { get; set; }
        public SerialInfo SerialInfo { get; set; }
        public MarketValueDetails MarketValueDetails { get; set; }
        public ProductionCondition ProductionCondition { get; set; }
        public List<string> DestinationCountries { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, Color color, Channel channel, SerialInfo serialInfo, 
                       MarketValueDetails marketValueDetails, ProductionCondition productionCondition, 
                       List<string> destinationConutries)
        {
            Id = id;
            Name = name;
            Color = color;
            Channel = channel;
            SerialInfo = serialInfo;
            MarketValueDetails = marketValueDetails;
            ProductionCondition = productionCondition;
            DestinationCountries = destinationConutries;
        }

        public override string ToString()
        {
           return string.Format("ID: {0}, Name: {1}, Channel: {2}, Price: {3}, Serial Number: {4}, Countries: {5}"
                , Id, Name, Channel, MarketValueDetails.Price, SerialInfo.SerialNumber, string.Join(", ", DestinationCountries));
        }
    }
}
