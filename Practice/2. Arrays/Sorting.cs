using System;
using System.Linq;
class sorting
{
	public static void SortingArray()
    {
        int[] Array1 = new int[5];
        for(int i = 0; i< Array1.Length; i++)
        {
            Console.WriteLine("Enter " + i + " indexed element for the array");
            Array1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(Array1);
        for (int i = 0; i < Array1.Length; i++)
        {
            Console.WriteLine(Array1[i] + " ");
        }
        
    }
}