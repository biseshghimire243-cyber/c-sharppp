//Method Overloading Program
using System;

class overloading
{
    // Method with two integers
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method with three integers
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded method with two double values
    static double Add(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine("Sum of 10 and 20 = " + Add(10, 20));
        Console.WriteLine("Sum of 10, 20 and 30 = " + Add(10, 20, 30));
        Console.WriteLine("Sum of 10.5 and 20.5 = " + Add(10.5, 20.5));
    }
}