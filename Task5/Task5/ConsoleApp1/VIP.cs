using System;

namespace ConsoleApp1
{
    public class VIP : Ticket
    {
        public override double GetPrice()
        {
            return 20.0;
        }
        }
    }
