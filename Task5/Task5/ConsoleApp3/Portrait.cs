using System;

namespace ConsoleApp3
{
    public class Portrait : ArtPiece, IPainting
    {
        public string Medium { get; set; }

        public Portrait(string title, string artist, string medium) : base(title, artist)
        {
            Medium = medium;
        }

        public void Display()
        {
            Console.WriteLine($"Portrait: {Title} by {Artist}, Medium: {Medium}");
        }
    }
}