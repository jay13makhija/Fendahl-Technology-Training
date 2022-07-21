using System;

class Sample
{
    private readonly double Pi =3.14;
    
    public static void Main()
    {
        Sample sample = new Sample();
        Console.WriteLine("The value of Pi is " + sample.Pi);
    }
}