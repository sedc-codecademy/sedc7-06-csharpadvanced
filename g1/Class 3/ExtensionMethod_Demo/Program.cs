using System;
using System.Collections.Generic;

namespace ExtensionMethod_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BasketballClub basketClub = new BasketballClub();

            basketClub.Name = "LAL";
            basketClub.Squad = new Dictionary<int, string>
            {
                {1, "Lebron" },
                {2, "Trajan" },
                {3, "Risto" }
            };
            basketClub.Country = "USA";

            HandballClub handballClub = new HandballClub();
            handballClub.Name = "Vardar";
            handballClub.Squad = new Dictionary<int, string>
            {
                {31, "Dibirov" },
                {5, "Stoilov" },
                {18, "Karacic" }
            };
            handballClub.Country = "MKD";
            
            basketClub.PrintClubInfo(new List<string>() { "A1" });
            handballClub.PrintClubInfo(new List<string>() { "MTV" });

            string name = "Risto";
            Console.WriteLine(name.AddPrefix());

            Console.Read();
        }
    }
}
