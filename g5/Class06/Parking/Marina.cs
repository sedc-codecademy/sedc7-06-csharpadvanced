using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Marina : GenericParking<Boat>
    {
        public Marina(int capacity) : base(capacity)
        {
        }

        //public int Capacity { get; private set; }
        //public int Occupancy { get; private set; }
        //public int FreeCapacity
        //{
        //    get
        //    {
        //        return Capacity - Occupancy;
        //    }
        //}

        //private List<Boat> parkedVehicles = new List<Boat>();

        //public Marina(int capacity)
        //{
        //    Capacity = capacity;
        //    Occupancy = 0;
        //}

        //public void ParkVehicle(Boat vehicle)
        //{
        //    if (FreeCapacity > 0)
        //    {
        //        Occupancy += 1;
        //        parkedVehicles.Add(vehicle);
        //        vehicle.Parking = this;
        //    }
        //}

        //public void LeaveVehicle(Boat vehicle)
        //{
        //    if (parkedVehicles.Contains(vehicle))
        //    {
        //        Occupancy -= 1;
        //        parkedVehicles.Remove(vehicle);
        //        vehicle.Parking = null;
        //    }
        //}

    }
}
