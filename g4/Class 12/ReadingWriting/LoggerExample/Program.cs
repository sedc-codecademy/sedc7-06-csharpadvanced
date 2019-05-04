﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExample
{
    class Program
    {
        static LoggerService _logger = new LoggerService();
        static List<User> Users = new List<User>()
        {
            new User(){Username = "Bob20", Password = "123456", Age = 20, Id = 4 },
            new User(){Username = "JillCool", Password = "coolcat", Age = 34, Id = 12 },
            new User(){Username = "Gregonator", Password = "astalavista", Age = 44, Id = 76 }
        };
        public static void Login(string username, string password)
        {
            User user = Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            if (user == null) throw new InvalidLoginException(username);
            Console.WriteLine($"Welcome {username}!");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the amazing app!");
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();
                Login(username, password);

                // new wrong user
                // User newUser = new User() { Username = "Anne", Password = "myPass", Age = -2, Id = 109 };

                // invalid format error
                int invalidNum = int.Parse("hey");
            }
            catch (InvalidLoginException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Check your username and password and try again!");
                _logger.Log("InvalidLogin", ex.Message, ex.Username);
            }
            catch (InvalidUserPropertyException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try and enter a correct value please!");
                _logger.Log("InvalidUserProperty", ex.Message, ex.BrokenUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please try again or contact support!");
                _logger.Log(ex.GetType().Name, ex.Message);
                _logger.LogError();
            }
            Console.WriteLine("Enjoy your day!");
            Console.ReadLine();
        }
    }
}
