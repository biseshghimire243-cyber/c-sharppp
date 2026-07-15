using System;

[Obsolete("Use NewMethod instead")]
class OldCalculator
{
    public void OldMethod()
    {
        Console.WriteLine("This is the old method.");
    }
}

class AttributeProgram
{
    static void Main()
    {
        OldCalculator obj = new OldCalculator();
        obj.OldMethod();
    }
}