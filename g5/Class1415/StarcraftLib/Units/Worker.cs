using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarcraftLib.Units
{
    public abstract class Worker
    {
        public int HitPoints { get; set; }
        void GatherGas() { }
        void GatherCrystals() { }
    }
}
