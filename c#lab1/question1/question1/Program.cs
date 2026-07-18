using System;

class Calculate
{
    private int num1;
    private int num2;

    public void setData(int a, int b)
    {
        num1 = a;
        num2 = b;
    }

    public void FindSum()
    {
        Console.WriteLine("Sum = " + (num1 + num2));
    }

    public int FindMulti()
    {
        return num1 * num2;
    }

    public void FindDifference()
    {
        Console.WriteLine("Difference = " + (num1 - num2));
    }
}

class Program
{
    static void Main()
    {
        Calculate c = new Calculate();

        c.setData(20, 10);

        c.FindSum();

        Console.WriteLine("Multiplication = " + c.FindMulti());

        c.FindDifference();
    }
}