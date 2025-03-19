using System;

class Program
{
    static void Main()
    {
        int[,] apts = new int[12, 4];

        Random rand = new Random();
        for (int floor = 0; floor < 12; floor++) 
        {
            for (int apt = 0; apt < 4; apt++) 
            {
           
                apts[floor, apt] = rand.Next(0, 6);
            }
        }

        int tFloorResidents = 0;
        int fFloorResidents = 0;

        for (int apt = 0; apt < 4; apt++)
        {
            tFloorResidents += apts[2, apt]; 
            fFloorResidents += apts[4, apt]; 
        }

        Console.WriteLine($"На третьем этаже жильцов: {tFloorResidents}");
        Console.WriteLine($"На пятом этаже жильцов: {fFloorResidents}");

        if (tFloorResidents > fFloorResidents)
        {
            Console.WriteLine("На третьем этаже больше жильцов.");
        }
        else if (fFloorResidents > tFloorResidents)
        {
            Console.WriteLine("На пятом этаже больше жильцов.");
        }
        else
        {
            Console.WriteLine("На третьем и пятом этажах одинаковое количество жильцов.");
        }
    }
}