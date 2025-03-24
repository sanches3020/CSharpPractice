using System;

public delegate double OrderHandler(double amount);

public class OrderProcessor
{
    public void HandleOrder(double amount, OrderHandler handler)
    {
        double result = handler(amount);
        Console.WriteLine($"Обработанная сумма: {result}");
    }
}

class Program
{
    public static double ApplyDiscount(double amount)
    {
        double discount = 0.1;
        return amount - (amount * discount);
    }

    public static double CalculateTax(double amount)
    {
        double taxRate = 0.15;
        return amount + (amount * taxRate);
    }

    static void Main()
    {
        OrderProcessor processor = new OrderProcessor();
        double orderAmount = 100.0;

        Console.WriteLine("Применение скидки: ");
        processor.HandleOrder(orderAmount, ApplyDiscount);

        Console.WriteLine("Расчет налога: ");
        processor.HandleOrder(orderAmount, CalculateTax);
    }
}