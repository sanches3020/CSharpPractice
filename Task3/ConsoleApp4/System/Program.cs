using ConsoleApp4.System;
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tour[] tours = new Tour[]
            {
                new Tour("Париж", 7, 1200m, "Hotel Paris"),
                new Tour("Берлин", 5, 800m, "Hotel Berlin"),
                new Tour("Париж", 10, 1500m, "Luxury Hotel Paris"),
                new Tour("Рим", 4, 600m, "Hotel Rome")
            };

            TravelAgency agency = new TravelAgency(tours);
            agency.ShowLongestTour();
            agency.ShowToursBySpan("Париж");
        }
    }
}