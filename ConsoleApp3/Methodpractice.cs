using System;

class methodpractice
{
    // Static method for factorial
    static int Factorial(int n)
    {
        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        return fact;
    }

    // Non-static method
    public int Cube(int n)
    {
        return n * n * n;
    }

    static void Main()
    {
        Console.Write("Enter a number for factorial: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factorial = " + Factorial(num1));

        Console.Write("Enter a number for cube: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Create object of the same class
        methodpractice obj = new methodpractice();

        Console.WriteLine("Cube = " + obj.Cube(num2));
    }
}