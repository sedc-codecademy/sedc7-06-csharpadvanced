using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualEvents
{
    public class StringManager
    {
        public string Value { get; set; }
        public int NumberOfRuns { get; set; }

        public StringManagementDelegate Execute { get; set; }

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
