using System;

class Derived_1
{
    public int num1 = Convert.ToInt32(Console.ReadLine());
    public static void Func_1()
    {
        Console.WriteLine("Inside function");
    }
}

class Base_1: Derived_1
{
    public static void Main()
    {
        Console.WriteLine("Enter a number");
        Base_1 base_1 = new Base_1();
        Console.WriteLine(base_1.num1);
        Func_1();
    }
}