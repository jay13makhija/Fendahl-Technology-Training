class doWhile
{
	public static void DoWhile()
    {
        int num, counter = 0;
        do
        {
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            counter += num;
        } while (num != 0);
        Console.WriteLine("Counter sum is equal to " + counter);
    }
}