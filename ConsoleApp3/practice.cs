using System;

class Rectangle
{
    public double Length;
    public double Breadth;

    
    public double ComputeArea()
    {
        return Length * Breadth;
    }

   
    public double ComputePerimeter()
    {
        return 2 * (Length + Breadth);
    }
}

class Polygon
{
    static void Main()
    {
        
        Rectangle rect = new Rectangle();

        Console.Write("Enter Length: ");
        rect.Length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Breadth: ");
        rect.Breadth = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nArea = " + rect.ComputeArea());
        Console.WriteLine("Perimeter = " + rect.ComputePerimeter());
    }
}