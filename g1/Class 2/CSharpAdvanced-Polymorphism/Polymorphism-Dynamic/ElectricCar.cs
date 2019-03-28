using System;

namespace Polymorphism_Dynamic
{
    public class ElectricCar : ICar
    {
        public int BatteryLifeMonths { get; set; }
        public int BatteryDuration { get; set; }
        public string MotorNumber { get; set; }
        public ElectricCar()
        {
            MotorNumber = this.MotorNumber + "-E"; // E - for electric cars
        }
        public ElectricCar(string engineNumber)
        {
            MotorNumber = engineNumber + "-E";
        }
        public void Refuel()
        {
            Console.WriteLine("Charging battery");
        }
    }
}