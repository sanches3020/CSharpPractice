using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Computer
    {
        public abstract void Start();
        public virtual void Turnoff()
        {
            Console.WriteLine("Компьютер выключается.");
        }
    }
}