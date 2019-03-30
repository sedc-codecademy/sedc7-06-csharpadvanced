using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FighterApp.Classes;

namespace FighterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreetFighter mess = new StreetFighter(120, 2, 1, 7);
            ProFighter ryu = new ProFighter(150, 4, 2, 13);
            RockstarFighter blanka = new RockstarFighter(170, 5, 4, 17);

            ryu.DoBoxing(blanka);
            mess.DoStreet(blanka);
            blanka.DoBoxing(ryu);
            blanka.DoMuayThai(ryu);
            blanka.DoStreet(mess);

            Console.ReadLine();
        }
    }
}
