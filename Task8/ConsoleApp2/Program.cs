using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
      
        var observableList = new MyObservableList<string>();

        var manager = new ObservableListManager<string>(observableList);

        manager.AddItem("Первый элемент");
        manager.AddItem("Второй элемент");

        manager.ShowAllItems();

        manager.RemoveItem("Первый элемент");

        Console.WriteLine($"Количество оставшихся элементов: {manager.GetCount()}");
    }
}