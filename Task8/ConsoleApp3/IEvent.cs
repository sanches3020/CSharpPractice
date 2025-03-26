namespace ConsoleApp3
{
    public interface IEvent<T>
    {
        void Trigger(T data);
    }
}