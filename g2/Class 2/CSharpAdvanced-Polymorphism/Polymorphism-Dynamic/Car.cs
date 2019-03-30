using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Dynamic
{
    public interface ICar
    {
        string MotorNumber { get; set; }
        void Refuel();
    }
    public class NormalCar : ICar
    {
        public string MotorNumber { get; set; }
        public NormalCar()
        {
            this.MotorNumber = this.MotorNumber + "-N"; // N - for normal cars
        }
        public NormalCar(string engineNumber)
        {
            this.MotorNumber = engineNumber + "-N";
        }
        public void Refuel()
        {
            Console.WriteLine("Refueling with petrol");
        }               
    }

    public class ElectricCar : ICar
    {
        public int BateryLifeMonths { get; set; }
        public int BatteryDuration { get; set; }
        public string MotorNumber { get; set; }
        public ElectricCar()
        {
            this.MotorNumber = this.MotorNumber + "-E"; // E - for electric cars
        }
        public ElectricCar(string engineNumber)
        {
            this.MotorNumber = engineNumber + "-E";
        }
        public void Refuel()
        {
            Console.WriteLine("Charging battery");
        }
    }

    public class HybridCar : ICar
    {
        public int BateryLifeMonths { get; set; }
        public int BatteryDuration { get; set; }
        public string MotorNumber { get; set; }
        public HybridCar()
        {
            this.MotorNumber = this.MotorNumber + "-H"; // H - for hybrid
        }
        public HybridCar(string engineNumber)
        {
            this.MotorNumber = engineNumber + "-H";
        }
        public void Refuel()
        {
            Console.WriteLine("Hybrid refueling: Petrol or Baterry");
        }
    }
}
