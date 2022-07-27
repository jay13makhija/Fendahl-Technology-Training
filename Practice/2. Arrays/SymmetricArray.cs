class symetric 
{
	public static void Symmetric()
	{ 
		Console.Write("Enter a length of array");
		int n = int.Parse(Console.ReadLine());
		int[] array = new int[n];
		Console.WriteLine("Enter the elements of the array");
		for (int i = 0; i < n; i++)
		{
			array[i] = int.Parse(Console.ReadLine());
		}
		bool symmetric = true;
		for (int i = 0; i < array.Length / 2; i++)
		{
			if (array[i] != array[n - i - 1])
			{
				symmetric = false;
				break;
			}
		}
		if(symmetric)
        {
            Console.WriteLine("The Array is Symmetric in nature");
        }
        else
        {
            Console.WriteLine("The Array is not Symmetric in nature");
        }
	}
}