using System;

namespace DTOB
{
	class dtob
    {
        public static void Dtob()
        {
            Console.WriteLine("Enter a number in decimal");
            string s = Console.ReadLine();
            string result = Convert.ToString(Convert.ToInt32(s, 10), 2);
            Console.WriteLine("The binary value of " + s + " is " + result);

        }
    }
}