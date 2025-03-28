using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        ModeController modeController = ModeController.GetInstance();

        modeController.SetMode("отладочный");
        Console.WriteLine($"Текущий режим: {modeController.GetMode()}");

        modeController.SetMode("обычный");
        Console.WriteLine($"Текущий режим: {modeController.GetMode()}");

        ModeController anotherModeController = ModeController.GetInstance();
        Console.WriteLine($"Проверка экземпляра: {anotherModeController.GetMode()}");
    }
}