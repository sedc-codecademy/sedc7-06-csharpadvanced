namespace BooksProvider
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Series { get; set; }
        public int? SeriesIndex { get; set; }

        public override string ToString()
        {
            return $"#{ID} {Title} ({Year}) Series: '{Series}' SeriesIndes: {SeriesIndex}";
        }
    }
}