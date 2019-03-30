using System.Collections.Generic;

namespace ExtensionMethod_Demo
{
    public interface IClub
    {
        string Name { get; set; }
        Dictionary<int, string> Squad { get; set; }
        string Country { get; set; }
    }
}
