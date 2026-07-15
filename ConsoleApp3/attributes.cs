using System;

class StudentAttribute : Attribute
{
}

[StudentAttribute]
class StudentRecord
{
}

class CustomAttributeProgram
{
    static void Main()
    {
        Console.WriteLine("Custom Attribute Example");
    }
}