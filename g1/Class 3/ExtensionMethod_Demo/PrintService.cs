using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethod_Demo
{
    public static class PrintService
    {
        public static void PrintClubInfo(this IClub club, List<string> tvs)
        {
            Console.WriteLine($"Name: {club.Name}");
            Console.WriteLine($"Country: {club.Country}");
            foreach (var player in club.Squad.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}. {player.Value}");
            }

            foreach (var tv in tvs)
            {
                Console.WriteLine($"TV: {tv}");
            }
        }

        public static string AddPrefix(this string name)
        {
            return $"Mr. {name}";
        }

    }
}
