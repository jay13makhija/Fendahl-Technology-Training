class for_each{
	public static void ForEach()
    {
        Console.WriteLine("Enter length of the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ArraySample = new int[n];
        foreach(int arraysample in ArraySample)
        {
            Console.WriteLine(arraysample+1); 
        }
    }
}