using System;

namespace ConsoleApp2
{
    public class ObservableListManager<T>
    {
        private MyObservableList<T> _observableList;

        public ObservableListManager(MyObservableList<T> observableList)
        {
            _observableList = observableList;

            _observableList.ItemAdded += OnItemAdded;
            _observableList.ItemRemoved += OnItemRemoved;
        }

        private void OnItemAdded(T item)
        {
            Console.WriteLine($"Элемент добавлен: {item}");
        }

        private void OnItemRemoved(T item)
        {
            Console.WriteLine($"Элемент удален: {item}");
        }

        public void AddItem(T item)
        {
            _observableList.Add(item);
        }

        public bool RemoveItem(T item)
        {
            return _observableList.Remove(item);
        }

        public bool ContainsItem(T item)
        {
            return _observableList.Contains(item);
        }

        public void ShowAllItems()
        {
            var items = _observableList.GetAll();
            Console.WriteLine("Текущие элементы:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public int GetCount()
        {
            return _observableList.Count;
        }
    }
}