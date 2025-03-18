using System;

class Program
{
        static void Main()
    {
      
        double radius = 5.5; 
        double height = 7;   

        double surfaceArea = 2 * Math.PI * radius * (radius + height);

        Console.WriteLine($"Площадь поверхности цилиндра: {surfaceArea:F2} см²");
    }
}