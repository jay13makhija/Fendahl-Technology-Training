using System;

namespace Palindrome
{
	class rev
    {
        public static void Rev()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int num2 = num;
            while(num > 0)
            {
                count = (count * 10) + (num %10);
                num /= 10;
            }

            if (num2 == count)
            {
                Console.WriteLine("Number "+ num2 + " is a Palindrome");
            }
            else
            {
                Console.WriteLine("Number " + num2 + " is not Palindrome");
            }
        }
    }
}