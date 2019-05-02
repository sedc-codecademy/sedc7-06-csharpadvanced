using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    public class Team
    {
        public string BadgeImageUrl { get; set; }
        public string TeamImageUrl { get; set; }
        public string Name { get; set; }

        public List<Player> Players { get; set; }
    }
}
