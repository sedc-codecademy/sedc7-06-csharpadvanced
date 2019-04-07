using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyGenericClass<T>
    {
        private T _genericMemberVariable;

        public MyGenericClass(T value)
        {
            _genericMemberVariable = value;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine($"Generic Method - Parameter type: {typeof(T).ToString()}, value: {genericParameter}");
            Console.WriteLine($"Generic Method - Return type: {typeof(T).ToString()}, value: {_genericMemberVariable}");

            return _genericMemberVariable;
        }

        public T GenericProperty { get; set; }
    }

    //When deriving from a generic base class, you must provide a type argument instead of the base-class's generic type parameter
    class MyDerivedClass : MyGenericClass<string>
    {
        public MyDerivedClass(string text) : base(text)
        {

        }
        //implementation
    }

    //If you want the derived class to be generic then no need to specify type for the generic base class
    class MyDerivedClass<T> : MyGenericClass<T>
    {
        public MyDerivedClass(T value) : base(value)
        {

        }
        //implementation
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            - Generics allow you to define a class with placeholders for the type of its fields, methods, parameters, etc
            - Generics replace these placeholders with some specific type at compile time
            - A generic class can be defined using angle brackets <>
            - Generics increases the reusability of the code
            - Generic are type safe. You get compile time errors if you try to use a different type of data than the one specified in the definition
            - Generic has a performance advantage because it removes the possibilities of boxing and unboxing

            - When deriving from a generic base class, you must provide a type argument instead of the base-class's generic type parameter
            - If you want the derived class to be generic then no need to specify type for the generic base class
            */
            #endregion

            Console.WriteLine("\n-------------------- int Generic --------------------");
            MyGenericClass<int> intGeneric = new MyGenericClass<int>(10);
            int val = intGeneric.GenericMethod(200);

            Console.WriteLine("\n-------------------- string Generic --------------------");
            MyGenericClass<string> strGeneric = new MyGenericClass<string>("Hello Generic World");
            string result = strGeneric.GenericMethod("Generic Parameter");
            strGeneric.GenericProperty = "This is a generic property example.";
            Console.WriteLine($"Generic Property: {strGeneric.GenericProperty}");

            Console.ReadLine();
        }
    }
}
