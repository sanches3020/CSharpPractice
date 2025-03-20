using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Movies
{
    public class Cinema
    {
        private List<Movie> movies;

        public Cinema()
        {
            movies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public Movie GetLongestMovie()
        {
            if (movies.Count == 0) return null;

            Movie longestMovie = movies[0];

            for (int i = 1; i < movies.Count; i++)
            {
                if (movies[i].Span > longestMovie.Span)
                {
                    longestMovie = movies[i];
                }
            }

            return longestMovie;
        }

        public List<Movie> GetMoviesByGenre(string genre)
        {
            List<Movie> genreMovies = new List<Movie>();

            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                {
                    genreMovies.Add(movies[i]);
                }
            }

            return genreMovies;
        }

        public void DisplayMovies()
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"Title: {movies[i].Title}, Genre: {movies[i].Genre}, Duration: {movies[i].Span} min");
            }
        }
    }
}