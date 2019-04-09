using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGeneric
{
    public class NullableValue<T>
    {
        public bool HasValue { get; private set; }
        public T Value { get; private set; }

        public NullableValue(bool hasValue, T value)
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
