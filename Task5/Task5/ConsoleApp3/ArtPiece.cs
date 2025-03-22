using System;

namespace ConsoleApp3
{
    public abstract class ArtPiece
    {
        public string Title { get; set; }
        public string Artist { get; set; }

        protected ArtPiece(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }
    }
}