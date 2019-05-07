using StarcraftLib.Units;
using System.Collections.Generic;

namespace StarcraftLib
{
    public class Player
    {
        public Color Color { get; set; }
        public string Name { get; set; }
        public Race Race { get; set; }
        public List<Worker> Units { get; internal set; } = new List<Worker>();

        public override string ToString()
        {
            return $"Player {Name} is {Color} color and plays with the {Race} race";
        }
    }
}