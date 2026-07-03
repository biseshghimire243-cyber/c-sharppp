using System;

class Array
{
    static void Main()
    {
        
        Console.Write("Enter the number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        
        int[] numbers = new int[n];

       
        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }

        
        Console.WriteLine("Sum of the array = " + sum);
    }
}