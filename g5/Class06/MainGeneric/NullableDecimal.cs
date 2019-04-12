using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGeneric
{
    public class NullableDecimal
    {
        public bool HasValue { get; private set; }
        public decimal Value { get; private set; }

        public NullableDecimal(bool hasValue, decimal value = 0)
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
