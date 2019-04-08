using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualEvents
{
    public class StringEventManager
    {
        public string Value { get; set; }
        public int NumberOfRuns { get; set; }

        public event StringManagementDelegate Execute;

        internal void Run()
        {
            if (Execute != null)
            {
                for (int i = 0; i < NumberOfRuns; i++)
                {
                    Execute(Value);
                }
            }
        }
    }
}
