using System;

public class Sample
{
    public static void Display(ref int num1)
    {
        Console.WriteLine("The Sum of the two numbers is " + num1);
    }

    public static void Calculate(ref int num1, ref int num2)
    {
        num1 = num1 + num2;
        Display(ref num1);
    }
    public static void input(out int num1, out int num2)
    {
        Console.WriteLine("Enter the First number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second number");
        num2 = Convert.ToInt32(Console.ReadLine());

        Calculate(ref num1, ref num2);
    }

    public static void Main()
    {
        Console.WriteLine("Program to get sum of 2 number using out keyword\n");
        int num1, num2;
        input(out num1, out num2);
    }
}