using System;

namespace ConsoleApp3.Movies
{
    public sealed class ActionMovie : Movie
    {
        public ActionMovie(string title, int duration) : base(title, "Action", duration) { }
    }
}