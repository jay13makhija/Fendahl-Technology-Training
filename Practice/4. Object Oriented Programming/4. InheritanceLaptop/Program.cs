using System;

public class LaptopComponents
{
    public static int ram, strg, price;
    public static string name, processor;
    public static void Initialize()
    {
        Console.WriteLine("Enter the Laptop Brand name");
        name = Console.ReadLine();
        Console.WriteLine("Enter the Processor Specification");
        processor = Console.ReadLine();
        Console.WriteLine("Enter amount of Ram");
        ram = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter amount of Storage");
        strg = Convert.ToInt32(Console.ReadLine());
    }
    public static void Price()
    {
        Console.WriteLine("Enter cost of the Laptop");
        price = Convert.ToInt32(Console.ReadLine());
    }
}
public class Print:LaptopComponents
{
    public static void Main()
    {
        Initialize();
        Price();
        Console.WriteLine("Name of the Laptop Brand is " + name);
        Console.WriteLine("Laptop Processor is " + processor);
        Console.WriteLine("Laptop's Ram capacity is " + ram);
        Console.WriteLine("Laptop's Storage capacity is " + strg);
        Console.WriteLine("Price of Laptop is " + price);
    }
}