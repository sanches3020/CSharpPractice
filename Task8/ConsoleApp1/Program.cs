using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        TrafficQueue trafficQueue = new TrafficQueue();

        trafficQueue.AddCar(new Car("A123BC", DateTime.Now));
        trafficQueue.AddCar(new Car("B456CD", DateTime.Now));
        trafficQueue.AddCar(new Car("C789EF", DateTime.Now));

        Console.WriteLine($"Количество автомобилей в очереди: {trafficQueue.GetCarCount()}");

        trafficQueue.ShowAllCars();

        trafficQueue.FindCar("A123BC");

        trafficQueue.RemoveCar();

        Console.WriteLine($"Количество автомобилей в очереди: {trafficQueue.GetCarCount()}");
    }
}