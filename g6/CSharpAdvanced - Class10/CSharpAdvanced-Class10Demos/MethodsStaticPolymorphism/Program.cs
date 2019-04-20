using System;

namespace MethodsStaticPolymorphism
{
    public class MyCustomType
    {
        public string Name { get; set; }
        public int SomeValue { get; set; }

        public MyCustomType()
        {

        }

        public MyCustomType(string name, int number)
        {
            Name = name;
            SomeValue = number;
        }

        public static MyCustomType operator +(MyCustomType mytype1, MyCustomType mytype2)
        {
            MyCustomType result = new MyCustomType();
            result.Name = mytype1.Name + " " + mytype2.Name;
            result.SomeValue = mytype1.SomeValue + mytype2.SomeValue;

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyCustomType object1 = new MyCustomType("Miodrag", 10);
            MyCustomType object2 = new MyCustomType("Cekikj", 50);


            var result = object1 + object2; //Name= Miodrag Cekikj SomeValue = 60

            Console.ReadLine();
        }
    }
}