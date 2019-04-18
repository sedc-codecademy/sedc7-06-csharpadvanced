using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksProvider
{
    public class BooksLoader
    {
        public IEnumerable<Author> GetAllAuthors()
        {
            string authors = File.ReadAllText("authors.json");
            var result = JsonConvert.DeserializeObject<IEnumerable<Author>>(authors);
            return result;
        }

        public IEnumerable<AwardDetails> GetAwards()
        {
            string awards = File.ReadAllText("awards.json");
            var result = JsonConvert.DeserializeObject<Dictionary<int, IEnumerable<AwardDetails>>>(awards);

            var awardDetails = result.SelectMany(item => 
                item.Value.Select(ad => new AwardDetails {
                    Author = ad.Author,
                    Award = ad.Award,
                    Title = ad.Title,
                    Year = item.Key
                })).ToList();

            return awardDetails;
        }
    }
}
