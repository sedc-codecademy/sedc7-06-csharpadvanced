using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsAndEnums
{
    class Empty
    {
        public string myProp { get; set; }

    }
    class Program
    {
        
        enum Temperatures : int //int is the default type
        {
            WickedCold = -18,
            FreezingPoint = 0,
            LightJacketWeather = 16,
            SwimmingWeather = 23,
            BoilingPoint = 100,
        }
        enum DaysOfWeek
        {
            Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
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
            System.Console.WriteLine("Freezing point of water: {0}", FreezingPoint);
            System.Console.WriteLine("Boiling point of water: {0}", BoilingPoint);
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
            
        }
    }
}
