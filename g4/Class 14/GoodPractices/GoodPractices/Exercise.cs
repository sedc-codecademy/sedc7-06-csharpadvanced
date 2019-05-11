using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPractices
{
    public class loginUser
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public List<string> messages { get; set; }
    }
    // Bad Example
    public static class mainService
    {
        private static List<loginUser> DB = new List<loginUser>()
        {
            new loginUser(){username = "bob", password = "123456", messages = new List<string>() { "Hey", "Cal me", "Bob you the man!"}, id = 1232 }
        };

        public static void login()
        {
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine("Plaese choose:");
            Console.WriteLine("1) Login");
            Console.WriteLine("2) Register");
            string Answer = Console.ReadLine();
            if (Answer == "1")
            {
                Console.WriteLine("Please enter username:");
                string UserName = Console.ReadLine();
                Console.WriteLine("Please enter password:");
                string Password = Console.ReadLine();

                loginUser LoggedUser = DB.FirstOrDefault(x => x.username == UserName);
                if (LoggedUser == null)
                {
                    Console.WriteLine("The user does not exist!");
                    return;
                }
                if (LoggedUser.password != Password)
                {
                    Console.WriteLine("The password did not match the entered username!");
                    return;
                }
                Console.WriteLine($"Welcome {LoggedUser.username}!");
                Console.WriteLine("Here are your messages:");
                if (LoggedUser.messages == null)
                {
                    Console.WriteLine("No messages!");
                    return;
                };
                foreach (string message in LoggedUser.messages)
                {
                    Console.WriteLine(message);
                }
                Console.ReadLine();

            }
            else if (Answer == "2")
            {
                Console.WriteLine("Please enter username:");
                string UserName = Console.ReadLine();
                Console.WriteLine("Please enter password:");
                string PasswordName = Console.ReadLine();
                loginUser LoggedUser = DB.FirstOrDefault(x => x.username == UserName);
                if (LoggedUser != null)
                {
                    Console.WriteLine("User already exists!");
                    return;
                }
                Random RND = new Random();
                int randomid = RND.Next(1, 9999);
                loginUser newUser = new loginUser()
                {
                    username = UserName,
                    password = PasswordName,
                    id = randomid
                };
                DB.Add(newUser);
                Console.WriteLine("Registration complete!");
            }
            else
            {
                Console.WriteLine("Wrong input!");
                return;
            }
        }
    }

    // Good Example
    public class LoginUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> Messages { get; set; }
    }
    public class LoginService
    {
        private List<LoginUser> _db;
        private HelperService _helperService;
        public LoginService()
        {
            _helperService = new HelperService();
        }
        public LoginUser FindUser(string userName)
        {
            return _db.FirstOrDefault(x => x.Username == userName);
        }
        public bool LoginUser(string userName, string password)
        {
            LoginUser loggedIn = FindUser(userName);
            if (loggedIn.Password == password) return true;
            return false;
        }
        public bool RegisterUser(string userName, string password)
        {
            LoginUser existingUser = FindUser(userName);
            if (existingUser != null) return false;
            LoginUser newUser = new LoginUser()
            {
                Username = userName,
                Password = password,
                Id = _helperService.GetRandomNumber(1, 9999)
            };
            _db.Add(newUser);
            return true;
        }
    }
    public class HelperService
    {
        public int GetRandomNumber(int start, int end)
        {
            Random rnd = new Random();
            return rnd.Next(start, end);
        }
        public void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class ConsoleUiService
    {
        private HelperService _helperService;
        public ConsoleUiService()
        {
            _helperService = new HelperService();
        }
        public int AppWelcomeUi()
        {
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine("Plaese choose:");
            Console.WriteLine("1) Login");
            Console.WriteLine("2) Register");
            int answer = 0;
            int.TryParse(Console.ReadLine(), out answer);
            return answer;
        }
        public LoginUser UsernamePasswordUi()
        {
            Console.WriteLine("Please enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter password:");
            string password = Console.ReadLine();
            return new LoginUser()
            {
                Username = userName,
                Password = password
            };
        }
        public void LogInWelcomeUi(LoginUser user)
        {
            Console.WriteLine($"Welcome {user.Username}!");
            Console.WriteLine("Here are your messages:");
            if (user.Messages == null)
            {
                Console.WriteLine("No messages!");
                return;
            };
            _helperService.PrintList(user.Messages);
        }
    }
    public class MainServiceGood
    {
        private LoginService _loginService;
        private HelperService _helperService;
        private ConsoleUiService _uiService;
        public MainServiceGood()
        {
            _loginService = new LoginService();
            _helperService = new HelperService();
            _uiService = new ConsoleUiService();
        }
        public void AppInit()
        {
            int appChoice = _uiService.AppWelcomeUi();
            switch (appChoice)
            {
                case 1:
                    LoginUser loginUser = _uiService.UsernamePasswordUi();
                    LoginUser existingUser = _loginService.FindUser(loginUser.Username);

                    if (existingUser == null)
                    {
                        Console.WriteLine("User does not exist!");
                        return;
                    }

                    bool isUserValid = _loginService.LoginUser(loginUser.Username, loginUser.Password);
                    if (!isUserValid)
                    {
                        Console.WriteLine("Password did not match!");
                        return;
                    }

                    _uiService.LogInWelcomeUi(existingUser);
                    break;
                case 2:
                    LoginUser registerUser = _uiService.UsernamePasswordUi();
                    bool isRegistrationComplete = _loginService.RegisterUser(registerUser.Username, registerUser.Password);
                    if (!isRegistrationComplete)
                    {
                        Console.WriteLine("User already exists!");
                        return;
                    }
                    Console.WriteLine("Registration complete!");
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }
        }
    }
}
