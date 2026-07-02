using System;


class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}


class methodpractice2
     
{
    static void Main()
    {
        
        Calculator obj = new Calculator();

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = obj.Add(num1, num2);

        Console.WriteLine("Sum = " + result);
    }
}