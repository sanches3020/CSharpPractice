using System;


namespace ConsoleApp1
{
    class Car
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
}
