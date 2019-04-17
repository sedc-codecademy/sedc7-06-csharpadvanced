using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Boat : IVehicle<Boat>
    {
        public string Name { get; set; }
        public bool BesPlatno { get; set; }
        public GenericParking<Boat> Parking { get; set; }
    }
}
