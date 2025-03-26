namespace ConsoleApp3
{
    public class SimpleEvent<T> : IEvent<T>
    {

        public event Action<T> EventTriggered;

        public void Trigger(T data)
        {
            EventTriggered?.Invoke(data); 
        }
    }
}