using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class StringList : List<string>
    {
        public string JoinList(string separator)
        {
            return string.Join(separator, this);
        }
    }
}
