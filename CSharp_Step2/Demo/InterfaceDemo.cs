using System;
namespace InterfaceDEMO
{
    /// <summary>
    /// An interface is like a contract that defines what methods, properties, events, or indexers a class must implement,
    /// but does not provide any implementation itself.
    /// </summary>
    interface Movie1
    {
        string moviename { get; set; }
        string moviehero { get; set; }
        string moviedirector { get; set; }

        void MovieDetails();
        int MovieReleaseYear(int ReleaseYear);

        bool MovieHitorFlop(bool value);
    }

    interface Movie2
    {
        string movietwoname { get; set; }
        string movietwoheroine { get; set; }
        
        void MovieTwoDetails();
        int MovieTwoReleasedYear(int ReleaseYear);

        
    }
    class MovieClass : Movie1, Movie2
    {
        public string moviename { get; set; }
        public string moviehero { get; set; }
        public string moviedirector { get; set; }
        public string movietwoname { get; set ; }//movie2
        public string movietwoheroine { get ; set; }//movie2

        public int MovieReleaseYear(int ReleaseYear)
        {
            Console.WriteLine($"{moviename} is release in {ReleaseYear}.");
            return ReleaseYear;
        }

        public void MovieDetails()
        {
            Console.WriteLine($"{moviename} is directed by {moviedirector}.");
        }

        public bool MovieHitorFlop(bool value)
        {
            Console.WriteLine($"{moviename} is blockbuster Hit is it true ? yes it is {value}.");
            return value;
        }

        public void MovieTwoDetails()
        {
            Console.WriteLine($"{movietwoname} is Directed by SanjayLeelaBanshali");
        }

        public int MovieTwoReleasedYear(int ReleaseYear)
        {
            Console.WriteLine($"{movietwoname} is relased in {ReleaseYear} and Heroine is {movietwoheroine}.");
            return ReleaseYear;

        }
    }
    class MainProgram
    {
        static void Main()
        {
            Movie1 movie1 = new MovieClass();
            movie1.moviename = "Sakhi";
            movie1.moviehero = "Madhavan";
            movie1.moviedirector = "Mani Ratnam";

           // Console.WriteLine($"{movie1.moviename} is directed by  {movie1.moviedirector}.");
            movie1.MovieReleaseYear(2000);
            movie1.MovieDetails();
            movie1.MovieHitorFlop(true);

            //Movie2 interface calling
            Movie2 movie2 = new MovieClass();
            movie2.movietwoheroine = "Aishwarya Rai";
            movie2.movietwoname = "Jodha Akbar";
            movie2.MovieTwoDetails();
            movie2.MovieTwoReleasedYear(2008);

        }
    }
}