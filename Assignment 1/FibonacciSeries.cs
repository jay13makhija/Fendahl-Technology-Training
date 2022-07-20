class febo
{
	public static void Fibonacci()
    {
        Console.WriteLine("Enter the number\n");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num ==0)
        {
            Console.WriteLine("try again with value more than 0\n");
        }
        int c, a=0, b=1;
        for(int i=1; i <= num; i++)
        {
            if(i == 1)
            {
                Console.Write("0 ");
                continue;
            }
            else if (i==2)
            {
                Console.Write("1 ");
                continue;
            }
            c = a + b;
            Console.Write(c+" ");
            a = b;
            b = c;

        }

    }
}