using System;

class task3

{
    static void Main()
    {
    
        Console.Write("Введите размер матрицы N (меньше 10): ");
        int N = Convert.ToInt32(Console.ReadLine()); 

        Console.Write("Введите a (нижний предел): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите b (верхний предел): ");
        int b = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[N, N];
        Random random = new Random(); 

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = random.Next(a, b);
            }
        }

        Console.WriteLine("Вот наша матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t"); 
            }
            Console.WriteLine(); 
        }

        Console.Write("Введите K: ");
        int K = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите L: ");
        int L = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] >= K && matrix[i, j] < L) 
                {
                    sum += matrix[i, j]; 
                }
            }
        }

        Console.WriteLine($"Сумма чисел в промежутке [{K}, {L}): {sum}");

        Console.Write("Введите номер столбца k (начиная с 0): ");
        int kColumn = Convert.ToInt32(Console.ReadLine());

        int maxElement = matrix[0, kColumn]; 
        for (int i = 1; i < N; i++)
        {
            if (matrix[i, kColumn] > maxElement) 
            {
                maxElement = matrix[i, kColumn]; 
            }
        }

        Console.WriteLine($"Максимальный элемент в столбце {kColumn}: {maxElement}");
    }
}