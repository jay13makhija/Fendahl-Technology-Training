class ExplicitCasting
{
	public static void Explicit_Casting()
    {
        // Explicit casting is converting larger type to smaller type
        // Manual in nature

        double num = 65.4;
        Console.WriteLine(num + " " + num.GetType());

        float num2 = (float)num;
        Console.WriteLine(num2 + " " + num2.GetType());

        long num3 = (long)num2;
        Console.WriteLine(num3 + " " + num3.GetType());

        int num4 = (int)num3;
        Console.WriteLine(num4 + " " + num4.GetType());

        char c = (char)num4;
        Console.WriteLine(c + " " + c.GetType());
    }
}