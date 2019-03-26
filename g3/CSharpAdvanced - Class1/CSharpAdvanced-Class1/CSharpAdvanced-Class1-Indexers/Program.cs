using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced_Class1_Indexers
{
    class Program
    {
        class City
        {
            private string[] Cities = new[] { "Skopje", "Kumanovo", "Bitola", "Tetovo", "Prilep" };

            //this is the indexer
            public string this[int index]
            {
                get { return Cities[index]; }
                set { Cities[index] = value; }
            }
            public string Country { get; } = "Macedonia";
        }

        class SparseArray
        {
            public Dictionary<int, string> array = new Dictionary<int, string>();
            
            //indexer for the Key of the dictionary
            public string this[int i]
            {
                get
                {
                    if (!array.ContainsKey(i))
                        return null;
                    return array[i];
                }
                set
                {
                    if (!array.ContainsKey(i))
                        array[i] = value;
                }
            }
        }

        static void Main(string[] args)
        {
            #region Indexers Part 1
            City city = new City();
            string capital = city[0];
            Console.WriteLine("{0}, {1}", capital, city.Country);
            string thirdLargestCity = city[2];
            Console.WriteLine("{0}, {1}", thirdLargestCity, city.Country);
            #endregion
            
            #region Indexers Part 2
            SparseArray sparse = new SparseArray();
            Console.WriteLine(sparse[100]);
            Console.WriteLine(sparse[99]);
            Console.WriteLine("Sparse array doesn't fail");
            Console.WriteLine(sparse.array.Count);

            //this will fail
            Dictionary<int, string> array = new Dictionary<int, string>();
            //Console.WriteLine(array[100]);
            //Console.WriteLine("Dictionary does fail");

            //must like this
            array[100] = "neshto";
            Console.WriteLine(array[100]);
            //Console.WriteLine(array[99]);
            Console.WriteLine("Dictionary doesn't fail");
            Console.WriteLine(array.Count);             
            #endregion
        }
    }
}
