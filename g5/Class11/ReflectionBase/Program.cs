using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var wekoStr = "FirstName: Wekoslav, LastName: Stefanovski, Age: 41";
            var martianStr = "Author: Andy Weir, Title: The Martian, Year: 2014";
            var rectangleStr = "Width: 10, Height: 20";

            var weko = MakeObjectFromString<Person>(wekoStr);
            Console.WriteLine(weko);

            var martian = MakeObjectFromString<Book>(martianStr);
            Console.WriteLine(martian);

            var rectangle = MakeObjectFromString<Rectangle>(rectangleStr);
            Console.WriteLine(rectangle.GetArea());

            // Person weko = new Person("Wekoslav", "Stefanovski");
            Console.WriteLine(weko.FirstName);
            Console.WriteLine(weko.GetType().GetProperty("FirstName").GetValue(weko));

        }

        private static T MakeObjectFromString<T>(string objStr) where T: new()
        {
            var propValues = objStr.Split(',');
            var props = propValues.Select(pv => pv.Trim().Split(':').Select(s => s.Trim()).ToArray());
            var propsDict = new Dictionary<string, string>();
            foreach (var item in props)
            {
                propsDict.Add(item[0], item[1]);
            }

            Type type = typeof(T);
            var constructor = type.GetConstructors().Single(cons => cons.GetParameters().Length == 0);
            var result = constructor.Invoke(null);

            foreach (var prop in propsDict)
            {
                var pinfo = type.GetProperty(prop.Key);
                if (pinfo.PropertyType == typeof(int))
                {
                    pinfo.SetValue(result, int.Parse(prop.Value));
                }
                else
                {
                    pinfo.SetValue(result, prop.Value);
                }
            }

            return (T)result;
            //return new Person
            //{
            //    FirstName = propsDict["FirstName"],
            //    LastName = propsDict["LastName"],
            //    Age = int.Parse(propsDict["Age"])
            //};
        }

        static void ChangeProperty(object value, string propertyName, object newValue)
        {

        }
    }
}
