using System;
namespace Interface
{
    /// <summary>
    /// An interface is like a contract that defines what methods, properties, events, or indexers a class must implement,
    /// but does not provide any implementation itself.
    /// </summary>
    interface Movie1
    {
         string moviename {  get; set; }
        string moviehero {  get; set; }
        string moviebudget {  get; set; }

         void MovieDetails();
        int MovieCollections(int Day1Collection);

        bool MovieHitorFlop(bool value);
    }

    class Movie1Class : Movie1
    {
        public string moviename { get; set; }
        public string moviehero { get; set; }
        public string moviebudget { get; set; }

        public int MovieCollections(int Day1Collection)
        {
            Console.WriteLine($"Day1 of movie collected total {Day1Collection} worlwide.");
            return Day1Collection;
        }

        public void MovieDetails()
        {
            Console.WriteLine($"movie is directed by SSR and music director is MMK.");
        }

        public bool MovieHitorFlop(bool value)
        {
            Console.WriteLine($"Movie is blockbuster Hit is it true ? yes it is {value}.");
            return value;
        }
    }
    class MainProgram
    {
        static void Main()
        {
            Movie1 movie1 = new Movie1Class();
            movie1.moviename = "RRR";
            movie1.moviehero = "NTR & RC";
            movie1.moviebudget = "550 cr";

            Console.WriteLine($"{movie1.moviename} is directed by SSR and it's budget is {movie1.moviebudget}.");
            movie1.MovieCollections(257);
            movie1.MovieDetails();
            movie1.MovieHitorFlop(true);
        }
    }
}