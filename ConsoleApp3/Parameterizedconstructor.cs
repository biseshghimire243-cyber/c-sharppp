using System;

class Studenttt
{
    public string Name;
    public int Age;

    // Parameterized Constructor
    public Studenttt(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Parameterized
{
    static void Main()
    {
        Studenttt s1 = new Studenttt("Ram", 20);
        Studenttt s2 = new Studenttt("Hari", 22);

        s1.Display();
        Console.WriteLine();

        s2.Display();
    }
}