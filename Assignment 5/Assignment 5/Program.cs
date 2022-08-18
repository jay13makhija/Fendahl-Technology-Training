/*Assignment:
Implement the Class A which is abstract and contains abstract mehod(A1, A2, A3) + some 
non -abstract methhods(Aa1, Aa2)
Implement the Class B which is derived from A and mark this class also as abstract.
B contains abstract methods(B1, B2) and some non-abstract (concrete) methods(A1, Bb1)
Implement the Class C which is derived from B. 
What are responsibilities of class C here? which methods C should override  ? */


// Class C must override the abstract methods left which are
//  - From Class A ->  A2 and A3
//  - From Class B ->  B1 and B2
// Class C may also have some concrete methods. (in this we have taken for an example Cc1)

using System;

abstract class A
{
    public abstract void A1();
    public abstract void A2();
    public abstract void A3();

    public void Aa1()
    {
        Console.WriteLine("This is Aa1 method");
    }
    
    public void Aa2()
    {
        Console.WriteLine("This is Aa2 method");
    }
}

abstract class B: A
{
    public abstract void B1();

    public abstract void B2();

    public override void A1()
    {
        Console.WriteLine("This is A1 overridden method");
    }

    public void Bb1()
    {
        Console.WriteLine("This is Bb1 method");
    }

}

class C : B
{
    public override void A2()
    {
        Console.WriteLine("This is A2 overridden method");
    }

    public override void A3()
    {
        Console.WriteLine("This is A3 overridden method");
    }

    public override void B1()
    {
        Console.WriteLine("This is B1 overridden method");
    }

    public override void B2()
    {
        Console.WriteLine("This is B2 overridden method");
    }

    public void Cc1()
    {
        Console.WriteLine("This is Cc1 method");
    }
}

public class Test
{
    public static void Main()
    {
        C c = new C();

        c.A1();
        c.A2();
        c.A3();
        c.Aa1();
        c.Aa2();

        c.B1();
        c.B2();
        c.Bb1();

        c.Cc1();
    }
}