using System;

namespace ConsoleApp2
{
    class ObjectManager
    {
        public void AccessObject(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException("Объект не может быть равен null.");
            }

            Console.WriteLine("Доступ к объекту выполнен успешно.");
        }
    }
}