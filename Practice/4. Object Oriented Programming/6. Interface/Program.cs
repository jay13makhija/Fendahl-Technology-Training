using System;

public interface Color
{
    public void Red1();
  
}

public class Paint : Color
{
    public void Red1()
    {
        Console.WriteLine("This is the red color");
    }
}

public class main
{
    public static void Main()
    {
        Paint red = new Paint();
        red.Red1();
    }
}