using System;

namespace ConsoleApp5
{
    public class Desktop : Computer
    {
        public override void Start()
        {
            Console.WriteLine("Рабочий стол запускается.");
        }

        public override void Turnoff()
        {
            Console.WriteLine("Рабочий стол выключается.");
        }
    }
}