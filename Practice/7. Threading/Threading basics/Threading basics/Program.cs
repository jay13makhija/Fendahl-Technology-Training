using System;

class Raceing
{
    public static void Main()
    {
        Console.WriteLine("Let us start the race on the count of 3");
        Thread.Sleep(2000);
        Console.WriteLine("Starting Count");
        Thread.Sleep(1000);
        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.WriteLine("1");
        Console.WriteLine("Go!");
    }
}