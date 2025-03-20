using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Movies
{
    public sealed class ComedyMovie : Movie
    {
        public ComedyMovie(string title, int span) : base(title, "Comedy", span) { }
    }
}