using ConsoleApp3.Movies;
using System;

namespace ConsoleApp3.Movies
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();

            cinema.AddMovie(new ActionMovie("Fury Road", 120));
            cinema.AddMovie(new ActionMovie("John Wick", 101));
            cinema.AddMovie(new ComedyMovie("Superbad", 113));
            cinema.AddMovie(new ComedyMovie("The Hangover", 100));

            cinema.DisplayMovies();

            Movie longestMovie = cinema.GetLongestMovie();
            if (longestMovie != null)
            {
                Console.WriteLine($"\nLongest Movie: {longestMovie.Title} with span of {longestMovie.Span} min");
            }
            else
            {
                Console.WriteLine("\nNo movies available.");
            }

            var actionMovies = cinema.GetMoviesByGenre("Action");
            Console.WriteLine("\nAction Movies:");
            for (int i = 0; i < actionMovies.Count; i++)
            {
                Console.WriteLine(actionMovies[i].Title);
            }
        }
    }
}