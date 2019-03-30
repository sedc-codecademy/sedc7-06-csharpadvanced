using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public interface IAnimal
    {
        string Name { get; set; }        
    }
    public interface IPredator : IAnimal
    {
        int AttackSpeed { get; set; }
        void Attack(IPray pray);
    }
    public interface IPray : IAnimal
    {
        int FleeSpeed { get; set; }
        void Flee();
    }
}
