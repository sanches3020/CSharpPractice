using System;

namespace ConsoleApp3.Movies
{
    public abstract class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Span { get; set; }

        protected Movie(string title, string genre, int span)
        {
            Title = title;
            Genre = genre;
            Span = span;
        }
    }
}