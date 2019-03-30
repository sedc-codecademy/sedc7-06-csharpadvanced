using System;

namespace FootballClub_Partial
{
    public partial class FootballClub
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }

        partial void PrintSquad();
        partial void PrintTitles();

        public void PrintInfo()
        {
            Console.WriteLine($"Club: {Name}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Stadium: {Stadium}");
            PrintSquad();
            PrintTitles();
        }
    }
}
