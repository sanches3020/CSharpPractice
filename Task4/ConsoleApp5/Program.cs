using ConsoleApp5;
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Computer myDesktop = new Desktop();
            Computer myLaptop = new Laptop();

            myDesktop.Start();
            myDesktop.Turnoff();

            myLaptop.Start();
            myLaptop.Turnoff();
        }
    }
}