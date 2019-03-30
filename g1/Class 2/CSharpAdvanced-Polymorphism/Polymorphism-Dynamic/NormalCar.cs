using System;

namespace Polymorphism_Dynamic
{
    public class NormalCar : ICar
    {
        public string MotorNumber { get; set; }
        public NormalCar()
        {
            MotorNumber = MotorNumber + "-N"; // N - for normal cars
        }
        public NormalCar(string engineNumber)
        {
            MotorNumber = engineNumber + "-N";
        }
        public void Refuel()
        {
            Console.WriteLine("Refueling with petrol");
        }
    }
}