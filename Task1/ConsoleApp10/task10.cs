using System;

class task10
{
    static void Main()
    {
        Console.WriteLine("Трёхзначные авторморфные числа:");

        for (int i = 100; i <= 999; i++)
        {
     
            int square = i * i;

            if (square % 1000 == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}