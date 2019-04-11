using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking poc = new Parking(100);
            Car astra = new Car
            {
                Make = "Opel",
                Model = "Astra"
            };

            poc.ParkVehicle(astra);

            astra.LeaveParking();
        }
    }
}
