using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class StringEventManager
    {
        public string Value { get; set; }

        public event StringManagementDelegate Execute;

        internal void Run()
        {
            if (Execute != null)
            {
                if (Rand.TrueOrFalse())
                {
                    Execute(Value);
                }
            }
        }
    }
}
