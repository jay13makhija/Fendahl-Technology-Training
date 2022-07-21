namespace SumOfAllDigits
{
    public class sum
    {
        public static void Sum()
        {
            System.Console.WriteLine("Enter a Number");
            int count=0;
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                count += (num % 10);
                num = num / 10;
            }
            System.Console.WriteLine("Sum of all  digits = " + count );
        }
    }
}