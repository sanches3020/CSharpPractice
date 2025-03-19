using System;

class task4
{
    static void Main()
    {
       
        int[,] apartments = new int[12, 4];

        Random random = new Random();
        for (int floor = 0; floor < 12; floor++)
        {
            for (int apartment = 0; apartment < 4; apartment++)
            {
                apartments[floor, apartment] = random.Next(0, 6); 
            }
        }

        int thirdFloorResidents = 0;
        int fifthFloorResidents = 0;

        for (int apartment = 0; apartment < 4; apartment++)
        {
            thirdFloorResidents += apartments[2, apartment]; 
            fifthFloorResidents += apartments[4, apartment];  
        }

        Console.WriteLine($"Количество жильцов на третьем этаже: {thirdFloorResidents}");
        Console.WriteLine($"Количество жильцов на пятом этаже: {fifthFloorResidents}");

        if (thirdFloorResidents > fifthFloorResidents)
        {
            Console.WriteLine("На третьем этаже проживает больше людей.");
        }
        else if (fifthFloorResidents > thirdFloorResidents)
        {
            Console.WriteLine("На пятом этаже проживает больше людей.");
        }
        else
        {
            Console.WriteLine("На третьем и пятом этажах проживает одинаковое количество людей.");
        }
    }
}