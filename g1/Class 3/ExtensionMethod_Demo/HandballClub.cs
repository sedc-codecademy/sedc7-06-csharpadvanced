using System.Collections.Generic;

namespace ExtensionMethod_Demo
{
    class HandballClub : IClub
    {
        public string Name { get; set; }
        public Dictionary<int, string> Squad { get; set; }
        public string Country { get; set; }
        public int Titles { get; set; }
    }
}
