using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Parking
    {
        public int Capacity { get; private set; }
        public int Occupancy { get; private set; }
        public int FreeCapacity { get; private set; }

        public List<Car> ParkedVehicles { get; set; }

        public Parking(int capacity)
        {
            // todo
        }

        public void ParkVehicle(Car vehicle)
        {
            // to-do
        }

    }
}
