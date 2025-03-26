using System;

namespace ConsoleApp3
{
    public class EventManager<T>
    {
        private SimpleEvent<T> _simpleEvent;

        public EventManager()
        {
            _simpleEvent = new SimpleEvent<T>();
        }

        public void Subscribe(Action<T> eventHandler)
        {
            _simpleEvent.EventTriggered += eventHandler;
        }

        public void Unsubscribe(Action<T> eventHandler)
        {
            _simpleEvent.EventTriggered -= eventHandler;
        }

        public void RaiseEvent(T data)
        {
            _simpleEvent.Trigger(data);
        }
    }
}