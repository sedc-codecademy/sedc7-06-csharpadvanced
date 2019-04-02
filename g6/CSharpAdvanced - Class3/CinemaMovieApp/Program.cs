using System;
using System.Collections.Generic;

namespace CinemaMovieApp
{
    public enum Genre
    {
        Action,
        Horror,
        Psycho,
        Comedy
    }
    public class Movie
    {
        ////auto-implemented property
        //public int Duration { get; set; }

        /// <summary>
        /// We are creating private field _duration explicitly because we need to 
        /// implement a logic in the property. You can see below that we are checking
        /// if value > 0 , because we don't want the user to provide a negative
        /// value for duration of the film. It doesn't make sense right? :)
        /// </summary>
        private int _duration;
        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value > 0)
                    _duration = value;
            }
        }

        public Movie(string title, Genre gen, int rating, int price)
        {
            Title = title;
            Rating = rating;
            Genre = gen;
            TicketPrice = price;
        }
        
        /// <summary>
        /// Title and Genre are auto implemented properties. For these properties we are not doing
        /// any validations in the getter and setter , so we are not explicitly declaring
        ///  a private field _title and _genre. It is generated in the background for us by C# complier.
        ///  But if we need to implement some logic inside the getter or setter, we need to declare
        ///  private field explicitly and "play" with it inside the getter and setter.
        ///  Good example for that is the Duration property above..
        /// </summary>
        public string Title { get; set; }
        public Genre Genre { get; set; }

        private int _rating;
        public int Rating
        {
            get { return _rating; }
            set
            {
                if (value < 5 && value > 0)
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("Rating must be from one to five!");
                }
            }
        }
        public int TicketPrice { get; set; }
    }
    public class Hall
    {
        public Hall(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> moviesList { get; set; }

        public void NowPlaying(Movie film)
        {
            Console.WriteLine($"Now playing: {film.Title}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 8, 2);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2);
            Movie movie7 = new Movie("Forrest Gump", Genre.Comedy, 4, 2);
            Movie movie8 = new Movie("12 Angru Men", Genre.Comedy, 4, 2);
            Movie movie9 = new Movie("Passengers", Genre.Action, 4, 2);
            Movie movie10 = new Movie("Interstellar", Genre.Action, 4, 2);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2);
            Movie movie17 = new Movie("The Social Network", Genre.Horror, 4, 2);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Horror, 4, 2);
            Movie movie19 = new Movie("Inception", Genre.Action, 4, 2);
            Movie movie20 = new Movie("Avatar", Genre.Action, 4, 2);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

            Hall cinema1 = new Hall("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.moviesList = MovieSet1;
            Hall cinema2 = new Hall("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.moviesList = MovieSet2;
        }
    }
}
