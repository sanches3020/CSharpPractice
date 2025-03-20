using System;

class A
{
    private int a;
    private int b;

    public A(int aValue, int bValue)
    {
        a = aValue;
        b = bValue;
    }

    public double Calculate()
    {
        if (a == 0)
        {
            throw new DivideByZeroException("Значение a не может быть равно 0.");
        }
        return (3 * b - 2) / (4.0 * a * a);
    }

    public (int, int) Cube()
    {
        return (a * a * a, b * b * b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение для a:");
        int aValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для b:");
        int bValue = int.Parse(Console.ReadLine());

        A obj = new A(aValue, bValue);

        Console.WriteLine($"Значение a: {aValue}");
        Console.WriteLine($"Значение b: {bValue}");

        try
        {
            double expressionValue = obj.Calculate();
            Console.WriteLine($"Значение выражения: {expressionValue}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        var (aCubed, bCubed) = obj.Cube();
        Console.WriteLine($"a в кубе: {aCubed}");
        Console.WriteLine($"b в кубе: {bCubed}");
    }
}