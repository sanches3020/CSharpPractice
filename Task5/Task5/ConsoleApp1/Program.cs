using ConsoleApp1;
using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Ticket[] tickets = new Ticket[]
            {
                new Standard(),
                new VIP(),
                new Student(),
                new Standard(),
                new VIP(),
                new Student()
            };

            foreach (var ticket in tickets)
            {
                Console.WriteLine($"Стоимость билета: {ticket.GetPrice()}$");
            }
        }
    }
}