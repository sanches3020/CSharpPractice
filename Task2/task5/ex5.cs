using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[4, 4];
        Random random = new Random();

        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                matrix[i, j] = random.Next(1, 10); 

        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }

        for (int i = 0; i < 4; i++)
        {
            int sum = 0;
            for (int j = 0; j < 4; j++)
                sum += matrix[i, j];

            if (IsPrime(sum))
                Console.WriteLine($"Сумма чисел в строке {i + 1} ({sum}) является простым числом.");
            else
                Console.WriteLine($"Сумма чисел в строке {i + 1} ({sum}) не является простым числом.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false; 
        for (int i = 2; i <= Math.Sqrt(number); i++)
            if (number % i == 0) return false; 
        return true; 
    }
}