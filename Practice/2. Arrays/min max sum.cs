class minMaxSum
{
	public static void MinMaxSum()
    {
        int[] Sample_Array = new int[5];
        Console.WriteLine("Enter 5 elements for the array");
        for (int i = 0; i < Sample_Array.Length; i++)
        {
            Sample_Array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(Sample_Array.Max());
        Console.WriteLine(Sample_Array.Min());
        Console.WriteLine(Sample_Array.Sum());
    }
}