using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Boat : IVehicle
    {
        public string Name { get; set; }
        public bool BesPlatno { get; set; }
        public GenericParking<IVehicle> Parking { get; set; }
    }
}
