using ConsoleApp2;
using System;

class Program
{
    static void Main(string[] args)
    {
        ObjectHandler objectHandler = new ObjectHandler();

        try
        {

            objectHandler.HandleAccess(null);
        }
        catch (ObjectAccessException ex)
        {

            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine($"Внутреннее исключение: {ex.InnerException?.Message}");
            Console.WriteLine($"Стек вызовов: {ex.StackTrace}");
        }
    }
}