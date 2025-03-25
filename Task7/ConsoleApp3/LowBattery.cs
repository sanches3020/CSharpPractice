using System;

namespace ConsoleApp3
{
    public class LowBatteryException : Exception
    {
        public LowBatteryException() : base("Уровень заряда аккумулятора слишком низкий.")
        {
        }
        public LowBatteryException(string message) : base(message)
        {
        }
        public LowBatteryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
