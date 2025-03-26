using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class MyObservableList<T>
    {
        private List<T> _items; 
        public event Action<T> ItemAdded; 
        public event Action<T> ItemRemoved; 

        public MyObservableList()
        {
            _items = new List<T>(); 
        }

        public void Add(T item)
        {
            _items.Add(item);
            ItemAdded?.Invoke(item); 
        }

        public bool Remove(T item)
        {
            if (_items.Remove(item)) 
            {
                ItemRemoved?.Invoke(item); 
                return true;
            }
            return false; 
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public int Count => _items.Count;

        public void Clear()
        {
            _items.Clear();
        }

        public List<T> GetAll()
        {
            return new List<T>(_items); 
        }
    }
}