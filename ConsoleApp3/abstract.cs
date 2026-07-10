using System;

// Declare Delegate
delegate void Calculate(int a, int b);

class MathOperation
{
    public static void Add(int x, int y)
    {
        Console.WriteLine("Sum = " + (x + y));
    }

    static void Main()
    {
        Calculate c = Add;

        c(10, 20);
    }
}