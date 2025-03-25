using System;

namespace ConsoleApp2
{
    class ObjectHandler
    {
        private ObjectManager _objectManager = new ObjectManager();

        public void HandleAccess(object obj)
        {
            try
            {
                _objectManager.AccessObject(obj);
            }
            catch (NullReferenceException ex) { 
                throw new ObjectAccessException("Ошибка доступа к объекту", ex);
            }
        }
    }
}
       
       