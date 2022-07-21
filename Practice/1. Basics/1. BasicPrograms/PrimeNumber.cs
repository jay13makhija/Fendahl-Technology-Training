using System;

namespace prime
{
	class PrimeNo
    {
        public static void Prime()
        {
            Console.WriteLine("Enter number less than equal to 23");
            int num = Convert.ToInt32(Console.ReadLine());

            // Implemended the Wilson's Theorem to find a no. is Prime or not

            long fact_num = 1;
            for(int i = 1; i <= num-1; i++)
            {
                fact_num *= i;
            }
            fact_num += 1;

            if(fact_num%num == 0)
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number");
            }
        }
    }
}