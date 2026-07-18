using System;

class Number
{
    private int x;
    private int y;

    // Default Constructor
    public Number()
    {
        x = 0;
        y = 0;
    }

    // Parameterized Constructor
    public Number(int a, int b)
    {
        x = a;
        y = b;
    }

    public void DecideEven()
    {
        Console.WriteLine("Even Numbers:");

        for (int i = x; i <= y; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }

    public void DecideOdd()
    {
        Console.WriteLine("Odd Numbers:");

        for (int i = x; i <= y; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Number n = new Number(1, 10);

        n.DecideEven();
        n.DecideOdd();
    }
}