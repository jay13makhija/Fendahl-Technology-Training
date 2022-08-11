public class Poly
{
    public virtual void Sample()
    {
        Console.WriteLine("Virtual function");
    }
}

public class Poly2: Poly
{
    public override void Sample()
    {
        Console.WriteLine("Override Done!!");
    }
}

public class Poly3: Poly2
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public float Add(float a, float b)
    {
        return a + b;
    }
}

public class Poly4: Poly3
{
    
    public static void Main()
    {
        Poly4 p1 = new Poly4();
        // This is example of RunTime Polymorphism (Dynamic) (Early-binding) (Overriding)
        p1.Sample();
        // This is example of CompileTime Polymorphism (Static) (Late-binding) (Overloading)
        Console.WriteLine(p1.Add(2, 5));
        Console.WriteLine(p1.Add(2.3f, 4.5f));

    }
}