using System;
using System.Collections.Generic;

public class Car
{
    public string LicensePlate { get; set; }
    public DateTime EntryTime { get; set; }

    public Car(string licensePlate, DateTime entryTime)
    {
        LicensePlate = licensePlate;
        EntryTime = entryTime;
    }

    public override string ToString()
    {
        return $"Автомобиль: {LicensePlate}, Время въезда: {EntryTime}";
    }
}

public class TrafficQueue
{
    private Queue<Car> carQueue = new Queue<Car>();

    public void AddCar(Car car)
    {
        carQueue.Enqueue(car);
        Console.WriteLine($"Автомобиль {car.LicensePlate} добавлен в очередь.");
    }

    public Car RemoveCar()
    {
        if (carQueue.Count > 0)
        {
            Car removedCar = carQueue.Dequeue();
            Console.WriteLine($"Автомобиль {removedCar.LicensePlate} выехал из очереди.");
            return removedCar;
        }
        else
        {
            Console.WriteLine("Очередь пуста.");
            return null;
        }
    }

    public Car FindCar(string licensePlate)
    {
        foreach (var car in carQueue)
        {
            if (car.LicensePlate.Equals(licensePlate, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Автомобиль {licensePlate} найден в очереди.");
                return car;
            }
        }

        Console.WriteLine($"Автомобиль {licensePlate} не найден в очереди.");
        return null;
    }

    public int GetCarCount()
    {
        return carQueue.Count;
    }

    public void ShowAllCars()
    {
        Console.WriteLine("Автомобили в очереди:");

        foreach (var car in carQueue)
        {
            Console.WriteLine(car);
        }
    }
}