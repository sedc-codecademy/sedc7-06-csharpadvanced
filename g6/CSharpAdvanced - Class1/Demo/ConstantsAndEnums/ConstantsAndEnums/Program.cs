using System;

namespace ConstantsAndEnums
{
    class Program
    {
        enum Temperatures : int
        {
            WickedCold = -18,
            FreezingPoint = 0,
            LightJacketWeather = 16,
            SwimmingWeather = 23,
            BoilingPoint = 100,
        }
        enum DaysOfWeek
        {
            Monday = 0, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static void Main(string[] args)
        {
            #region Constants
            const int WickedCold = -18;
            const int FreezingPoint = 0;
            const int LightJacketWeather = 16;
            const int SwimmingWeather = 23;
            const int BoilingPoint = 100;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Constants");
            Console.WriteLine("Freezing point of water: {0}", (int)FreezingPoint);
            Console.WriteLine("Boiling point of water: {0}", (int)BoilingPoint);
            #endregion

            #region Enums
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enum Temperatures");
            Console.WriteLine("Freezing point of water: {0}", (int)Temperatures.FreezingPoint);
            Console.WriteLine("Boiling point of water: {0}", (int)Temperatures.BoilingPoint);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enum Days of week");
            Console.WriteLine($"First day of the week Monday: {(int)DaysOfWeek.Monday}");
            Console.WriteLine($"Second day of the week Tuesday: {(int)DaysOfWeek.Tuesday}");
            #endregion

            Console.ReadLine();
        }
    }
}
