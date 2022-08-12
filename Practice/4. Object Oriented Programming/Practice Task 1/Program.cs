/*Create a C# program that implements an abstract class Animal that has a Name property of type
text and three methods SetName (string name), GetName and Eat. The Eat method will be an abstract
method of type void.
You will also need to create a Dog class that implements the above Animal class and the Eat
method that says the dog is Eating.
To test the program ask the user for a dog name and create a new Dog type object from the Main
of the program, give the Dog object a name, and then execute the GetName and Eat methods.*/

using System;
public abstract class Animal
{
    public static string Name;

    public string SetName(string Name)
    {
        return Name;
    }

    public void GetName()
    {
        Console.WriteLine("The Dog name is " + Name);
    }
    public abstract void Eat();
}

public class Dog: Animal
{

    public override void Eat()
    {
        Console.WriteLine("Dog is Eating");
    }

    public static void Main()
    {
        Console.WriteLine("Enter the Dog name");
        Dog dog = new Dog(); 
        Name = Console.ReadLine();
        dog.SetName(Name);
        dog.GetName();
        dog.Eat();
    }

}
