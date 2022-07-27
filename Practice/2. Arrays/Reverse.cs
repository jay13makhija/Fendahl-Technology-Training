using System;

class reverse
{
    public static void Reverse()
    {
        Console.WriteLine("Enter the size for the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] og_array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the element for the index " + i);
            og_array[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] ReverseArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            ReverseArray[n - i - 1] = og_array[i];
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(ReverseArray[i] + " ");
        }
    }
}