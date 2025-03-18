using System;

class task7
{
    static void Main()
    {
        Console.Write("Введите A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите B: ");
        int B = int.Parse(Console.ReadLine());

        Console.WriteLine("Целые положительные числа от A до B:");
        int i = A;
        while (i <= B)
        {
            if (i > 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

        Console.WriteLine("Целые положительные числа от A до B :");
        i = A; 
        do
        {
            if (i > 0)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= B);

        Console.WriteLine("Целые положительные числа от A до B:");
        for (i = A; i <= B; i++)
        {
            if (i > 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}