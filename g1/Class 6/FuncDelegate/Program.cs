using System;

namespace FuncDelegate
{
    class Program
    {
        public delegate void MyDelegate(string first, string last);

        static void Main(string[] args)
        {
            #region Anonymous Functions
            MyDelegate d = delegate (string first, string last) { Console.WriteLine($"{first} {last}"); };

            MyDelegate d1 = (first, last) => { Console.WriteLine($"Mr. {first} {last}"); };

            d += d1;
            d("Risto", "Panchevski");
            #endregion

            #region Action Generic
            Action<int> squareArea = delegate (int a) { Console.WriteLine($"Square Area: {a * a}"); };
            Action<int, int> rectangleArea = (a, b) => { Console.WriteLine($"Rectangle Area: {a * b}"); };
            Action<int> circleArea = r => Console.WriteLine($"Circle Area: {r * r * 3.14}");

            squareArea(5);
            rectangleArea(3, 4);
            circleArea(3);
            #endregion

            #region Function Generic
            Func<int, int> cubeVolume = a => a * a * a;
            Func<float, float, float, float> cube2Volume = (a, b, c) => a * b * c;
            Func<int, double> ballVolume = (r) => { return (4 / 3) * r * r * r * 3.14; };
            Func<string, string, string> f = FullName;
            Func<string, string, string> f1 = delegate (string first, string last) { return $"Mr. {first} {last}"; };

            f += f1;

            Console.WriteLine(cubeVolume(2));
            Console.WriteLine(cube2Volume(4, 5, 6));
            Console.WriteLine(ballVolume(3));
            Console.WriteLine(f("Risto", "Panchevski"));
            Console.WriteLine(FullName("Risto", "Panchevski"));
            #endregion
        }

        public static string FullName(string first, string last)
        {
            return $"{first} {last}";
        }

    }
}
