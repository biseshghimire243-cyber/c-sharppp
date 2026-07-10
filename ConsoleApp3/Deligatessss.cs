using System;

// Declare Delegate
delegate void MyDelegate();

class Demo
{
    // Method
    public static void Message()
    {
        Console.WriteLine("Hello! This is Delegate Example.");
    }

    static void Main()
    {
        // Create delegate object
        MyDelegate d = Message;

        // Call method using delegate
        d();
    }
}