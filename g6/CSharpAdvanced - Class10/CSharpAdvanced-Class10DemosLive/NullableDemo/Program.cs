using System;

namespace NullableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = new DateTime(2019, 1, 1);

            DateTime date3 = new DateTime(); //default date time

            //if (date != null)
            //    date3 = date.GetValueOrDefault();
            //else
            //    date3 = DateTime.Today;

            //ternary operator '?'
            date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date3);

            //null-coalescing operator '??'
            date3 = date ?? DateTime.Today;

            Console.ReadLine();

        }
    }
}
