using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        LoginManager loginManager = new LoginManager();
        int attempts;

        Console.WriteLine("Введите количество попыток входа (максимум 3, завершите ввод - введите любое число, большее 3):");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out attempts))
            {
                if (attempts <= 0)
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите число.");
                continue;
            }

            try
            {
                loginManager.AttemptLogin(attempts);
            }
            catch (TooManyLoginAttemptsException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                break; 
            }
            Console.WriteLine(); 
        }
    }
}