//4.Delegate
//Definition

//A delegate is like a pointer to a method.
using System;

delegate void MyDelegate();

class Test
{
    public static void Hello()
    {
        Console.WriteLine("Hello World");
    }

    static void Main()
    {
        MyDelegate d = Hello;
        d();
    }
}