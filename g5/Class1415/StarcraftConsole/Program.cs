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
            starcraft.AddPlayer(new Player { Name = "Pero2", Color = Color.Blue, Race = Race.Terran });
            //starcraft.AddPlayer(new Player { Name = "Pero3", Color = Color.Blue, Race = Race.Zerg });

            var result = starcraft.StartGame();
            Console.WriteLine(result);



            
        }
    }
}
