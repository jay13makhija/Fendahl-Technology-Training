using System;
using System.Threading;

class Multi_Thread
{
    public static void Main()
    {
        Thread SecondThread = new Thread(new ThreadStart(Print));

        SecondThread.Start();

        Console.WriteLine("Counting to 10 in 1 second each");
        //Main thread (which is presend by default)
        for (int i = 10; i > 0; i--)
        {
            Thread.Sleep(1000);
            Console.WriteLine(i);
        }
    }

    public static void Print()
    {
        int num = 10;
        for(int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}