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
            //Car astra = new Car
            //{
            //    Make = "Opel",
            //    Model = "Astra"
            //};

            //poc.ParkVehicle(astra);

            //astra.LeaveParking();


            var addressBook = new AddressBook();

            Console.WriteLine(addressBook.ContainsKey("Risto"));
            Console.WriteLine(addressBook.ContainsKey("Blazo"));
            addressBook.Add("Blazo", 12345);
            Console.WriteLine(addressBook["Blazo"]);

            foreach (var item in addressBook)
            {
                Console.WriteLine("{0} {1}",item.Key, item.Value);
            }

            var abc = new StringList { "A", "B", "C" };
            abc.Add("D");
            Console.WriteLine(abc.JoinList(","));

        }
    }
}

