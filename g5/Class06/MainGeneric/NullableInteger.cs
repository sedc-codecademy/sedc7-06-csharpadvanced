using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGeneric
{
    public class NullableInteger
    {
        public bool HasValue { get; private set; }
        public int Value { get; private set; }

        public NullableInteger(bool hasValue, int value = 0)
        {
            HasValue = hasValue;
            Value = value;
        }

        public override string ToString()
        {
            if (HasValue)
            {
                return Value.ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
