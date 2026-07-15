using System;

class AnimalInfo
{
    public void Eat()
    {
        Console.WriteLine("Animal is Eating");
    }
}

class DogInfo : AnimalInfo
{
    public void Bark()
    {
        Console.WriteLine("Dog is Barking");
    }
}

class AnimalProgram
{
    static void Main()
    {
        DogInfo d = new DogInfo();

        d.Eat();
        d.Bark();
    }
}