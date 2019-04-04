using System.Collections.Generic;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            //info part 1
            c.Name = "Coca Cola";
            c.Industry = "Beverages";
            c.Founded = 1886;
            c.Headquarters = "Atlanta, Georgia, USA";
            c.Products = new List<string> { "Coca cola", "Coca cola Zero", "Fanta", "Sprite" };
            c.Revenue = 35410000000;
            c.NumberOfEmploees = 60000;
            c.AreaServed = "Globally";
            c.Website = "https://www.coca-colacompany.com/";

            c.Info();
        }
    }
}