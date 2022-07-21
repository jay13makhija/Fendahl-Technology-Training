class banking
{
	public static void Bank()
    {
        Console.WriteLine("Enter your bank balance");
        int num = Convert.ToInt32(Console.ReadLine());
        here:
        Console.WriteLine("Choose your operations\n");
        Console.WriteLine("1.Withdrow 2.Deposit 3.Check Balance 4.Exit");
        int n = Convert.ToInt32(Console.ReadLine());
        switch(n)
        {
            case 1:
                Console.WriteLine("Enter amount to withdraw");
                int withdraw_num = Convert.ToInt32(Console.ReadLine());
                if(withdraw_num > num)
                {
                    Console.WriteLine("Not sufficent balance");
                    goto here;
                }
                num -= withdraw_num;
                Console.WriteLine("Amount withdrawn successfully");
                goto here;
            case 2:
                Console.WriteLine("Enter amount to deposit");
                int dep_num = Convert.ToInt32(Console.ReadLine());
                num += dep_num;
                Console.WriteLine("Amount deposited successfully");
                goto here;
            case 3:
                Console.WriteLine("Your current balance is "+ num);
                goto here;
            case 4:
                break;

            default:
                Console.WriteLine("Wrong Case Please try again");
                goto here;
        }
    }
}