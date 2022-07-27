class binarySearch
{
	public static void BinarySearch()
    {
        int[] Array2 = new int[5];
        Console.WriteLine("Enter 5 numbers");
        for (int i=0; i<Array2.Length; i++)
        {
            Array2[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Enter element to search");
        int num = Convert.ToInt32(Console.ReadLine());
        if (Array.BinarySearch(Array2, num) < 0)
        {
            Console.WriteLine("Element is not in the array");
        }
        else
        {
            Console.WriteLine("Index of " + num + " is " + Array.BinarySearch(Array2, num));
        }
    }
}