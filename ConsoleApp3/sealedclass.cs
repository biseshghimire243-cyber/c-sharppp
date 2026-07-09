//2.Sealed Class
//Definition

//A sealed class cannot be inherited.
using System;

sealed class Animal
{
    public void Show()
    {
        Console.WriteLine("Animal Class");
    }
}

class SealedProgram
{
    static void Main()
    {
        Animal a = new Animal();
        a.Show();
    }
}