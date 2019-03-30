using System;
using System.Collections.Generic;

namespace FootballClub_Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballClub milan = new FootballClub();
            milan.Squad = new Dictionary<int, string>
            {
                {1, "Donaruma" },
                {2, "Conti" },
                {8, "Susso" },
                {3, "Maldini" },
                {10, "Kaka" }
            };
            milan.Name = "Milan";
            milan.City = "Milano";
            milan.Stadium = "San Siro";
            milan.ChampionsLeagueTitles = 7;
            milan.Titles = 18;
            milan.CupTitles = 12;

            milan.PrintInfo();
            Console.Read();
        }
    }
}
