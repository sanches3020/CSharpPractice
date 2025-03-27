using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            EventManager<string> eventManager = new EventManager<string>();
            eventManager.Subscribe(OnEventTriggered);
            eventManager.RaiseEvent("Первое событие!");
            eventManager.RaiseEvent("Второе событие!");

            eventManager.Unsubscribe(OnEventTriggered);
        }

        static void OnEventTriggered(string message)
        {
            Console.WriteLine($"Событие вызвано: {message}");
        }
    }
}
