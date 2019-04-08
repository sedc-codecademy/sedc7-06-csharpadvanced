using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class StringEventManager
    {
        public string Value { get; set; }

        public event Action<string> Execute;

        public Func<string, string> Transform;

        internal void Run()
        {
            if (Execute != null)
            {
                if (Rand.TrueOrFalse())
                {
                    Execute(Transform(Value));
                }
                if (Rand.TrueOrFalse())
                {
                    Execute(Transform(Value));
                }
                if (Rand.TrueOrFalse())
                {
                    Execute(Transform(Value));
                }
            }
        }
    }
}
