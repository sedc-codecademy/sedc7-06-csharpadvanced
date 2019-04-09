using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingStrings
{
    static class PersonGenerator
    {
        public static List<Person> GetPersons()
        {
            string[] fnames = {"Andrea", "Bojan", "Vladimir", "Goran", "Dejan", "Gjorgji", "Emil", "Zharko", "Zoran", "Dzvonko", "Petar", "Risto", "Stanko"};
            string[] mnames = { "Aleksandar", "Blagoj", "Venko", "Gorjan", "Dragan", "Gjoko", "Efrem", "Zhivko", "Zlatko", "Dzvonko" };
            string[] lnames = { "Aleksandrov", "Blagojevski", "Venkoski", "Gorjanov", "Draganski", "Gjokov", "Efremov", "Zhivkov", "Zlatkov", "Dzvonkov", "Samardziski" };

            List<Person> result = new List<Person>();

            for (int x = 0; x < 200; x++)
            {
                for (int i = 0; i < fnames.Length; i++)
                {
                    for (int j = 0; j < mnames.Length; j++)
                    {
                        for (int k = 0; k < lnames.Length; k++)
                        {
                            result.Add(new Person
                            {
                                FirstName = fnames[i],
                                MiddleName = mnames[j],
                                LastName = lnames[k]
                            });
                        }
                    }
                }
            }

            return result;
        }
    }
}
