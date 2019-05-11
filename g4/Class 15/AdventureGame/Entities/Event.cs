using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int HealthModifier { get; set; }
        public int ArmorModifier { get; set; }
        public int FoodModifier { get; set; }
        public EventType Type { get; set; }
    }
}
