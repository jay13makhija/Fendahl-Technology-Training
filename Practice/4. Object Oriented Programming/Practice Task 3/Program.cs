/*Create a C# program that requests three names of people from the user and stores them in an array
    of objects of type Person. To do this, first create a Person class that has a Name property of
    type string and override the ToString() method.
End the program by reading people and executing the ToString() method on the screen.*/


class Person
{
    public string Name;
}

class MainClass: Person
{
    public override string ToString()
    {
        return base.ToString();
    }
    public static void Main()
    {
        string[] array = new string[3];
        for (int i = 0; i < 3; i++)
        {
            Person p1 = new Person();
            Console.WriteLine("Enter " + (i+1) + " name");
            array[i] = (p1.Name = Console.ReadLine());
        }
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(array[i]);
        }

    }
}

