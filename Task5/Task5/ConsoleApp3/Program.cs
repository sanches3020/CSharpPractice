using ConsoleApp3;
using System;

namespace СonsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtPiece[] artPieces = new ArtPiece[]
            {
                new Portrait("Mona Lisa", "Leonardo da Vinci", "Oil on canvas"),
                new Statue("David", "Michelangelo", "Marble", "5.17 m"),
                new Portrait("The Starry Night", "Vincent van Gogh", "Oil on canvas"),
                new Statue("The Thinker", "Auguste Rodin", "Bronze", "1.88 m")
            };

            Console.WriteLine("Скульптуры в галерее:");
            foreach (ArtPiece artPiece in artPieces)
            {
                if (artPiece is ISculpture sculpture)
                {
                    sculpture.ShowDimensions();
                }
            }
        }
    }
}