using System;
class swap
{
	public static void Swapping()
    {
        Console.WriteLine("Enter two numbers");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int temp;
        temp = num2;
        num2 = num1;
        num1 = temp;
        Console.WriteLine("After swapping first number is " + num1 + " and second number is " + num2);
    }
}