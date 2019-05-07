using StarcraftLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarcraftConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Game starcraft = new Game();
            starcraft.MapName = "Big Game Hunters";

            starcraft.AddPlayer(new Player { Name = "Pero1", Color = Color.Blue, Race = Race.Protoss });
            starcraft.AddPlayer(new Player { Name = "Pero2", Color = Color.Orange, Race = Race.Terran });
            starcraft.AddPlayer("Pero3");
            starcraft.AddPlayer("Pero4");
            starcraft.AddPlayer(new Player { Name = "Pero5", Color = Color.Yellow, Race = Race.Zerg});

            var result = starcraft.StartGame();
            Console.WriteLine(result);

            PrintPlayers(starcraft);
        }

        static void PrintPlayers(Game game)
        {
            foreach (var player in game.Players)
            {
                Console.WriteLine(player);
                foreach (var unit in player.Units)
                {
                    Console.WriteLine($" - {unit}");
                }
            }
        }
    }
}
