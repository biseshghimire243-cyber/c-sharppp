//1.Abstract Class
//Definition

//An abstract class is a class that cannot be instantiated (no object can be created directly). It is used as a base class.

//Declared using abstract
//Can contain both abstract and normal methods.
//The derived class must implement all abstract methods.
//Example
using System;

abstract class Shape
{
    public abstract void Area();

    public void Display()
    {
        Console.WriteLine("Shape Class");
    }
}

class Rectangle : Shape
{
    public override void Area()
    {
        Console.WriteLine("Area = Length × Breadth");
    }
}

class AbstractProgram
{
    static void Main()
    {
        Rectangle r = new Rectangle();
        r.Display();
        r.Area();
    }
}