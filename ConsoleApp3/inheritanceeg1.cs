//Inheritance in C# – Notes
//Definition

//Inheritance is an Object-Oriented Programming (OOP) feature that allows one class to inherit the properties(fields) and methods of another class.

//The class whose members are inherited is called the Base Class (Parent Class).
//The class that inherits is called the Derived Class(Child Class).

//In C#, inheritance is implemented using the : (colon) operator.

//Syntax
//class Parent
//{
//    // Fields and Methods
//}

//class Child : Parent
//{
//    // Additional Fields and Methods
//}
//Example 1 (Simple Inheritance)
using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is Eating");
    }
}

class Dog : Animal
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
        Dog d = new Dog();

        d.Eat();
        d.Bark();
    }
}