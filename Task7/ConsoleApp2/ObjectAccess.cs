using System;

namespace ConsoleApp2
{
    public class ObjectAccessException : Exception
    {
        public ObjectAccessException() : base("Ошибка доступа к объекту.")
        {
        }

        public ObjectAccessException(string message) : base(message)
        {
        }

        public ObjectAccessException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}