using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var wekoStr = "Име: Wekoslav, Презиме: Stefanovski, Age: 41, Secret: I once killed a man just to watch him die";
            var martianStr = "Author: Andy Weir, Title: The Martian, Year: 2014";
            var rectangleStr = "Width: 10, Height: 20";

            var weko = Deserialize<Person>(wekoStr);
            Console.WriteLine(weko);
            Console.WriteLine(weko.Secret);

            var martian = Deserialize<Book>(martianStr);
            Console.WriteLine(martian);

            var rectangle = Deserialize<Rectangle>(rectangleStr);
            Console.WriteLine(rectangle.GetArea());

            // Person weko = new Person("Wekoslav", "Stefanovski");
            Console.WriteLine(weko.FirstName);
            Console.WriteLine(weko.GetType().GetProperty("FirstName").GetValue(weko));

            var andrea = new Person
            {
                FirstName = "Andrea",
                LastName = "Markovski",
                Age = 35,
                Secret = "I like My Little Pony"
            };

            var andreaStr = Serialize(andrea);
            Console.WriteLine(andreaStr);

            File.WriteAllText("andrea.txt", andreaStr);
        }

        //private static string MakeStringFromObject<T>(T value)
        private static string Serialize<T>(T value)
        {
            var props = typeof(T).GetProperties()
                .Where(pi => pi.CanRead && pi.CanWrite)
                .Where(pi => IsIgnored(pi) == false);

            var propValues = props.Select(pi => $"{GetPropertyName(pi)}: {pi.GetValue(value)}");
            var result = string.Join(", ", propValues);
            return result;
        }

        private static object GetPropertyName(PropertyInfo pi)
        {
            var sedcAttribute = pi.GetCustomAttribute<SedcAttribute>();
            if ((sedcAttribute == null) || string.IsNullOrEmpty(sedcAttribute.StringName))
            {
                return pi.Name;
            }
            else 
            {
                return sedcAttribute.StringName;
            }
        }

        private static bool IsIgnored(PropertyInfo pi)
        {
            var sedcAttribute = pi.GetCustomAttribute<SedcAttribute>();
            return (sedcAttribute != null) && sedcAttribute.Ignore;
        }

        //private static T MakeObjectFromString<T>(string objStr) where T: new()
        private static T Deserialize<T>(string objStr) where T : new()
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
                var pinfo = GetPropertyInfo(type, prop.Key);
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

        private static PropertyInfo GetPropertyInfo(Type type, string key)
        {
            var pinfo = type.GetProperty(key);
            if (pinfo != null)
            {
                return pinfo;
            }
            return type
                .GetProperties()
                .Select(pi => new { Property = pi, Attribute = pi.GetCustomAttribute<SedcAttribute>() })
                .Where(pa => pa.Attribute != null)
                .Single(pa => pa.Attribute.StringName == key)
                .Property;
        }

        static void ChangeProperty(object value, string propertyName, object newValue)
        {

        }
    }
}
