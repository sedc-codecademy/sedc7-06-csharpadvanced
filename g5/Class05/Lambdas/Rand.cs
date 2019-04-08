using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    static class Rand
    {
        static private Random random = new Random();

        static public bool TrueOrFalse()
        {
            return random.NextDouble() > 0.5;
        }
    }
}
