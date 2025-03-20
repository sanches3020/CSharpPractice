using ConsoleApp4.System;

    public class TravelAgency
{
    private Tour[] tours;

    public TravelAgency(Tour[] tours)
    {
        this.tours = tours;
    }

    public void ShowLongestTour()
    {
        Tour longestTour = Tour.GetLongestTour(tours);
        Console.WriteLine("Самый длинный тур: " + longestTour.Span + ", Длительность: " + longestTour.Duration + " дней");
    }

    public void ShowToursBySpan(string span)
    {
        Tour[] matchingTours = Tour.GetToursBySpan(tours, span);
        Console.WriteLine("Туры в " + span + ":");
        foreach (var tour in matchingTours)
        {
            Console.WriteLine("- " + tour.Span + ", Длительность: " + tour.Duration + " дней");
        }
    }
}
