class CallByRefVal
{
    public static int Sub(ref int a, ref int b)
    {
        int temp;
        temp = a;
        a = b;
        b = temp;
        return a-b;
    }
    public static double Divide(double a, double b)
    {
        double temp;
        temp=a;
        a = b;
        b = temp;
        return a/b;
    }
    public static void Main()
    {
        int a, b;
        Double c, d;
        Console.WriteLine("Enter two integers to add");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter two float numbers divide");
        c = Convert.ToDouble(Console.ReadLine());
        d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Sub(ref a, ref b));
        Console.WriteLine(Divide(c, d));
    }
}
