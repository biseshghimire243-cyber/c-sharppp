using System;

class ArithmeticOperation
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nArithmetic Operations:");
        Console.WriteLine("Addition = " + (num1 + num2));
        Console.WriteLine("Subtraction = " + (num1 - num2));
        Console.WriteLine("Multiplication = " + (num1 * num2));

        if (num2 != 0)
        {
            Console.WriteLine("Division = " + (num1 / num2));
            Console.WriteLine("Modulus = " + (num1 % num2));
        }
        else
        {
            Console.WriteLine("Division and Modulus cannot be performed because the second number is 0.");
        }
    }
}