using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionBase
{
    public class SedcAttribute: Attribute
    {
        public string StringName { get; set; }
        public bool Ignore { get; set; }
    }
}
