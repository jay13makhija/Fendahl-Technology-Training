class primeNum
{
    static bool CheckPrime(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
	public static void PrimeNum()
    {
        Console.WriteLine("Enter number\n");
        int num = Convert.ToInt32(Console.ReadLine());
        if (CheckPrime(num))
        {
            Console.WriteLine("Number is Prime\n");
        }
        else
        {
            Console.WriteLine("Number is not Prime\n");
        }
        
    }
}