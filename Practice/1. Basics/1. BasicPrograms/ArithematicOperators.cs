class ArithematicOperators
{
	public static void ArithematicOperator()
    {
        Console.WriteLine("Enter two numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of the two numbers is ");
        System.Console.WriteLine(a + b);
        Console.WriteLine("The difference of the two numbers is ");
        System.Console.WriteLine(a - b);
        Console.WriteLine("The product of the two numbers is ");
        System.Console.WriteLine(a * b);
        Console.WriteLine("The division of the two numbers is ");
        System.Console.WriteLine(a / b);
        Console.WriteLine("The remainder after division of two numbers is ");
        System.Console.WriteLine(a & b);
    }
}