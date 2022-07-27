using System;
class array
{
	public static void Array()
    {
        int[] IntArray = new int[10];
        Console.WriteLine("To enter 10 numbers to store in array");
        for(int i=1; i<=10; i++)
        {
            Console.WriteLine("Enter " + i + " element of the array");
            IntArray[i-1]= Convert.ToInt32(Console.ReadLine()); 
        }
        for(int i=0; i <10; i++)
        {
            Console.WriteLine(IntArray[i]+"\n");
        }

    }
}