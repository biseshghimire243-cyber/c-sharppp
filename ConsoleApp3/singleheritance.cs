using System;

class AnimalA
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class DogA : AnimalA
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class SingleInheritanceProgram
{
    static void Main()
    {
        DogA d = new DogA();

        d.Eat();
        d.Bark();
    }
}