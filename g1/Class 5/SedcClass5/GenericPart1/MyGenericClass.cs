using System;

namespace GenericPart1
{
    public class MyGenericClass<T>
    {
        public void PrintPropertyInfo(T prop)
        {
            Console.WriteLine($"Value: {prop.ToString()}");
            Console.WriteLine($"Type: {GetPropertyType(prop)}");
        }

        private string GetPropertyType(T prop)
        {
            if (prop.GetType() == typeof(string))
            {
                return "STRING";
            }
            else if(prop.GetType() == typeof(int))
            {
                return "INTEGER";
            }
            else if (prop is char)
            {
                return "CHAR";
            }

            return "Not known property type";
        }
    }
}
