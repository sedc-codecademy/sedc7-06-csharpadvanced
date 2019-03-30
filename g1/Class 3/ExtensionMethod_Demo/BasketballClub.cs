using System.Collections.Generic;

namespace ExtensionMethod_Demo
{
    public class BasketballClub : IClub
    {
        public string Name { get; set; }
        public Dictionary<int, string> Squad { get; set; }
        public string Country { get; set; }
        public string Hall { get; set; }
    }
}
