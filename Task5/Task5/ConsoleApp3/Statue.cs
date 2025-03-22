using System;

namespace ConsoleApp3
{
    public class Statue : ArtPiece, ISculpture
    {
        public string Material { get; set; }
        public string Dimensions { get; set; }

        public Statue(string title, string artist, string material, string dimensions)
            : base(title, artist)
        {
            Material = material;
            Dimensions = dimensions;
        }

        public void ShowDimensions()
        {
            Console.WriteLine($"Statue: {Title} by {Artist}, Material: {Material}, Dimensions: {Dimensions}");
        }
    }
}