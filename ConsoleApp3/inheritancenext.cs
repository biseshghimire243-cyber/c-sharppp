//3.Inheritance
//Definition

//Inheritance allows one class to inherit the properties and methods of another class.
using System;

class Person
{
    public void Show()
    {
        Console.WriteLine("Person");
    }
}

class Student : Person
{
    public void Study()
    {
        Console.WriteLine("Studying");
    }
}

class InheritanceProgram
{
    static void Main()
    {
        Student s = new Student();

        s.Show();
        s.Study();
    }
}