using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class AddressBook : Dictionary<string, int>
    {
        int GetNaRistoBrojot()
        {
            return this["Risto"];
        }

        public AddressBook()
        {
            Add("Risto", 223305);
        }

    }

}
