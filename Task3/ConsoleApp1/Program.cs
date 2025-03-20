using System;

using System.Runtime.CompilerServices;

class A 
{
    private int a;
    private int b;

    public A(int aValue,int bValue)
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