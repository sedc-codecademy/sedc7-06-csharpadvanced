using System;

namespace FootballClub_Partial
{
    partial class FootballClub
    {
        public int Titles { get; set; }
        public int ChampionsLeagueTitles { get; set; }
        public int CupTitles { get; set; }

        partial void PrintTitles()
        {
            Console.WriteLine("Titles:");
            Console.WriteLine($"Titles in a League: {Titles}");
            Console.WriteLine($"Titles in a Champions League: {ChampionsLeagueTitles}");
            Console.WriteLine($"Titles in a Cup: {CupTitles}");
        }
    }
}
