using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GameService
    {
        private HelperService _helperService;
        private List<Event> _events;
        private int _point;
        private string _eventsPath = @"C:\Users\DraganGelevski\source\repos\AdventureGame\Services\Events\events.json";
        public GameService()
        {
            _helperService = new HelperService();
            string eventsJson = _helperService.ReadFromFileSystem(_eventsPath);
            _events = _helperService.DeserializeEvents(eventsJson);
            _point = 0;
        }
        public List<Event> GetAllEvents()
        {
            return _events;
        }
        public Event GetEventByIndex(int index)
        {
            return _events[index];
        }
        public int RollDice()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 7);
            Console.WriteLine($"You rolled {roll}");
            return roll;
        }
        public GameStatus CheckGameStatus(Hero hero, int field)
        {
            if (hero.Health == 0) return GameStatus.Lose;
            if (field >= 29) return GameStatus.Win;
            return GameStatus.Continue;
        }
        public bool StartGame(Hero hero)
        {
            _point = 0;
            Console.WriteLine("Welcome to the Adventure Game!");
            Console.WriteLine("Press anything to start...");
            Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Press anything to roll a dice...");
                string cheat = Console.ReadLine();
                if(cheat == "aspirine")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Cheat activated! Health 999");
                    hero.Health = 999;
                    Console.ResetColor();
                }
                int roll = RollDice();
                _point += roll;
                if (_point > 29) _point = 29;
                Console.WriteLine($"You are now on the {_point} point!");
                Event pointEvent = GetEventByIndex(_point);
                pointEvent.PrintEvent();
                hero.TriggerEvent(pointEvent);
                hero.PrintStats();
                switch(CheckGameStatus(hero, _point))
                {
                    case GameStatus.Win:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congrats! YOU WON!");
                        Console.ResetColor();
                        Console.WriteLine("Press anything to play again...");
                        return true;
                    case GameStatus.Lose:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry! YOU LOST!");
                        Console.ResetColor();
                        Console.WriteLine("Press anything to play again...");
                        return true;
                    case GameStatus.Continue:
                        Console.WriteLine("You continue your jorney...");
                        break;
                    default:
                        Console.WriteLine("ERROR!");
                        break;
                }
            }
        }
    }
}
