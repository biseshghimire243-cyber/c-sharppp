using System;

class Student
{
    public string Name;
    public int Age;

    // Default Constructor
    public Student()
    {
        Name = "Bishesh";
        Age = 23;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Default
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Display();
    }
}