using System;

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

        static void Main(string[] args)
        {
            #region Indexers
            City city = new City();
            string capital = city[0];
            Console.WriteLine("{0}, {1}", capital, city.Country);
            string thirdLargestCity = city[2];
            Console.WriteLine("{0}, {1}", thirdLargestCity, city.Country);
            #endregion
        }
    }
}