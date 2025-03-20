using System;

namespace ConsoleApp4.System
{
    public class Tour
    {
        public string Span { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public string Hotel { get; set; }

        public Tour(string span, int duration, decimal price, string hotel)
        {
            Span = span;
            Duration = duration;
            Price = price;
            Hotel = hotel;
        }

        public static Tour GetLongestTour(Tour[] tours)
        {
            Tour longest = tours[0];
            for (int i = 1; i < tours.Length; i++)
            {
                if (tours[i].Duration > longest.Duration)
                {
                    longest = tours[i];
                }
            }
            return longest;
        }

        public static Tour[] GetToursBySpan(Tour[] tours, string span)
        {
            Tour[] matchingTours = new Tour[tours.Length];
            int count = 0;

            for (int i = 0; i < tours.Length; i++)
            {
                if (tours[i].Span.Equals(span, StringComparison.OrdinalIgnoreCase))
                {
                    matchingTours[count] = tours[i];
                    count++;
                }
            }

            Array.Resize(ref matchingTours, count);
            return matchingTours;
        }
    }
}