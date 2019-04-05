using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Db
    {
        public static List<string> Names = new List<string>() {
            "Bob", "Jill", "Greg"
        };
        public static List<Human> Humans = new List<Human>();
    }
}
