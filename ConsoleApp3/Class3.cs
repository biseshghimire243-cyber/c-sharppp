using System;

class TargetExample
{
    [Obsolete]
    public void Show()
    {
        Console.WriteLine("Hello from Attribute Target");
    }
}

class AttributeTargetProgram
{
    static void Main()
    {
        TargetExample obj = new TargetExample();
        obj.Show();
    }
}