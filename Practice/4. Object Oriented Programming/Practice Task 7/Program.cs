/*Create a C# program that implements an abstract class Animal that has a Name property of type text and
three methods SetName (string name), GetName and Eat. The Eat method will be an abstract method of type void.

You will also need to create a Dog class that implements the above Animal class and the Eat method that says
the dog is Eating.

To test the program ask the user for a dog name and create a new Dog type object from the Main of the program,
give the Dog object a name, and then execute the GetName and Eat methods.*/

using System;

public abstract class Animal
{
    public string Name;

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract void Eat();
}

public class Dog:Animal
{
    public override void Eat()
    {
        Console.WriteLine("The dog is Eating");
    }
}

public class Test
{
    public static void Main()
    {
        Dog dog = new Dog();
        Console.WriteLine("Enter the name for the dog");
        dog.SetName(Console.ReadLine());
        Console.WriteLine("The name of the Dog is " + (dog.GetName()));
        dog.Eat();
    }
}