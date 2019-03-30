using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballClub_Partial
{
    partial class FootballClub
    {
        public Dictionary<int, string> Squad { get; set; }

        partial void PrintSquad()
        {
            string squadString = "Squad: \n";

            foreach (var player in Squad.OrderBy(x => x.Key))
            {
                squadString += $"{player.Key}. {player.Value}\n";
            }

            Console.WriteLine(squadString);
        }
    }
}
