class Program
{
    static void Main(string[] args)
    {
        string directoryToWatch = @"..\..";
        FileWatcher watcher = new FileWatcher(directoryToWatch);

        Console.WriteLine("Нажмите [Enter] для выхода...");
        Console.ReadLine();
    }
}