using System;

namespace GenericPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<string> stringGeneric = new MyGenericClass<string>();
            MyGenericClass<int> intGeneric = new MyGenericClass<int>();
            MyGenericClass<bool> boolGeneric = new MyGenericClass<bool>();
            MyGenericClass<User> userGeneric = new MyGenericClass<User>();

            stringGeneric.PrintPropertyInfo("Risto");
            intGeneric.PrintPropertyInfo(3);
            boolGeneric.PrintPropertyInfo(true);

            User u = new User("Trajan", "Stevkovski");
            userGeneric.PrintPropertyInfo(u);

            Console.ReadKey();
        }
    }
}
