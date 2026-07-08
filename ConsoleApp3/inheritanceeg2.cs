//inheritance eg 2a
using System;

class HumanInfo
{
    public string Name = "Ram";
    public int Age = 20;

    public void ShowHuman()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class CollegeStudent : HumanInfo
{
    public string Faculty = "BSc.CSIT";

    public void ShowFaculty()
    {
        Console.WriteLine("Faculty: " + Faculty);
    }
}

class InheritanceProgram
{
    static void Main()
    {
        CollegeStudent s = new CollegeStudent();

        s.ShowHuman();
        s.ShowFaculty();
    }
}