using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Laptop : Computer
    {
        public override void Start()
        {
            Console.WriteLine("Ноутбук запускается.");
        }

        public override void Turnoff()
        {
            Console.WriteLine("Ноутбук выключается.");
        }
    }
}