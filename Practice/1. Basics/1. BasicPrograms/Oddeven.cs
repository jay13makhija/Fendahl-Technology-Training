using System;

namespace Oddeven{
	 
	class OE
    {
		public static void OddEven()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%2 != 0 )
            {
                Console.WriteLine(num + " is odd number");
            }
            else
            {
                Console.WriteLine(num + " is a even number");
            }
        }
    }

}