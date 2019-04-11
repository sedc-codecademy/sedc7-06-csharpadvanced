using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public interface IVehicle
    {
        GenericParking<IVehicle> Parking {get; set;}
    }
}
