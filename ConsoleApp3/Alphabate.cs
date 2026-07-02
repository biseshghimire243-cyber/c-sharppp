using System;

class Alphabate
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());

        if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
        {
            Console.WriteLine(ch + " is an Alphabet.");
        }
        else if (ch >= '0' && ch <= '9')
        {
            Console.WriteLine(ch + " is a Number.");
        }
        else
        {
            Console.WriteLine(ch + " is a Special Character.");
        }
    }
}