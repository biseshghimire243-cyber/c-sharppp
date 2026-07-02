using System;

class Armstrong
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int remainder;
        int result = 0;

        while (number != 0)
        {
            remainder = number % 10;
            result = result + (remainder * remainder * remainder);
            number = number / 10;
        }

        if (result == originalNumber)
        {
            Console.WriteLine(originalNumber + " is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not an Armstrong number.");
        }
    }
}
