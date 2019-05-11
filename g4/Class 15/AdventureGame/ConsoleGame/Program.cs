using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        private static GameService _gameService = new GameService();
        static void Main(string[] args)
        {
            while (true)
            {
                Hero hero = new Hero();
                _gameService.StartGame(hero);
            };
        }
    }
}
