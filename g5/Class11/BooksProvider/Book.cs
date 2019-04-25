using Newtonsoft.Json;
using System;

namespace BooksProvider
{
    [JsonObject]
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [JsonProperty(PropertyName = "titleMk")]
        [Obsolete("Не чепкајте го насловот")]
        public string Наслов { get; set; }

        public int Year { get; set; }
        public string Series { get; set; }
        public int? SeriesIndex { get; set; }

        public string SeriesDisplay {
            get
            {
                if (string.IsNullOrEmpty(Series))
                {
                    return "Not a part of a series";
                }
                if (SeriesIndex.HasValue)
                {
                    return $"Book {SeriesIndex} of {Series}";
                }
                else
                {
                    return $"Book of {Series}";
                }
            }
        }

        public string IdTitle
        {
            get
            {
                return $"#{ID} {Title}";
            }
        }

        public override string ToString()
        {
            return $"#{ID} {Title} ({Year}) Series: '{Series}' SeriesIndes: {SeriesIndex}";
        }
    }
}