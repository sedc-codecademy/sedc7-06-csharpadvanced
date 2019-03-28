using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var academy = InitializeAcademy();
            Console.Write("Enter username: ");
            var username = Console.ReadLine();

            academy.Login(username);
            var loggedUser = academy.CurrentUser;
            if (loggedUser == null)
            {
                var oldcolor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid username");
                Console.ForegroundColor = oldcolor;
                return;
            }

            Console.WriteLine($"Welcome {loggedUser.Username}");
            Console.WriteLine($"You are logged in as {loggedUser.GetRole()}");

            var something = loggedUser.GetSomething();
            foreach (var item in something)
            {
                Console.WriteLine(item);
            }
                
            //Console.WriteLine("-----------");
            //foreach (User user in academy.Users)
            //{
            //    Console.WriteLine(user.GetRole());
            //}
        }

        private static Academy InitializeAcademy()
        {
            var result = new Academy("SEDC");
            result.AddUser(new Admin { Username = "admin" });
            result.AddUser(new Teacher { Username = "weko" });
            result.AddUser(new Student { Username = "emilija" });

            result.Courses.Add(new Course { Title = "Advanced C#" });
            return result;
        }
    }
}
