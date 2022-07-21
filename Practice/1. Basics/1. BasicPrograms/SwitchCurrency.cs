class switchstatement
{ 
       public static void Ss()
       {
        test:
        Console.WriteLine("Welcome to currrency converter");
        Console.WriteLine("Enter your choice\n 1. Rupee to US Dollor\n 2. US Dollor to Rupee\n 3. Rupee to Euro\n 4. Euro to Rupee\n 5. Exit \n");
        int num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.WriteLine("Enter Amount in Rupee");
                double C_num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine((C_num / 75) + "$");
                goto test;
            case 2:
                Console.WriteLine("Enter Amount in US dollor");
                int C2_num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Rs." + (C2_num * 75));
                goto test;
            case 3:
                Console.WriteLine("Enter Amount in Rupee");
                double C3_num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine((C3_num / 80) + " Euro");
                goto test;
            case 4:
                Console.WriteLine("Enter Amount in Rupee");
                int C4_num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Rs." + (C4_num * 80));
                goto test;
            case 5:
                break;

            default:
                Console.WriteLine("Case Not Found");
                goto test;
        }

       }
}