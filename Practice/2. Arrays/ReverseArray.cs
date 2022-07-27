class rev
{
	public static void ReverseArray()
    {
        int[] array = new int[5];
        for(int i=0; i<array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Reverse(array);
        for(int i=0; i<array.Length; i++)
        {
            Console.Write(array[i]+" ");
        }
    }
}