class ImplicitCasting
{
	public static void Implicit_Casting()
    {
        // Implicit casting is converting smaller type to larger type
        // Automatic in nature

        char c = 'B';
        Console.WriteLine(c + " " + c.GetType());

        int n = c;
        Console.WriteLine(n + " " + n.GetType());

        long num = n;
        Console.WriteLine(num + " " + num.GetType());

        float num2 = num;
        Console.WriteLine(num2 + " " + num2.GetType());

        double num3 = num2;
        Console.WriteLine(num3 + " " + num3.GetType());
    }
}