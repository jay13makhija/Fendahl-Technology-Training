using System;

namespace Armstrong
{
	
	class arm
    {
		public static void Arm()
        {
            Console.WriteLine("Enter the Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int num2 = num;

            while(num > 0)
            {
                int number = num % 10;
                double Result = Math.Pow(number, 3);
                sum += Convert.ToInt32(Result);
                num /= 10;
            }

            if (sum == num2)
            {
                Console.WriteLine(num2 + " is an Armstrong Number");
            }
            else
            {
                Console.WriteLine(num2 + " is not an Armstrong Number");
            }

        }
    }

}