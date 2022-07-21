//(new modifier) of the new keyword
/*To hide an inherited member, declare it in the derived 
class by using the same member name, and modify it with the *new* keyword.*/

// new keyword is used to create instance of an array

// new operator is used to create an object or instantiate an objectusing System;

class Base
{
    protected int num1;
    protected int num2;
    
    public static int add(int num1, int num2)
    {
        return num1 + num2;
    }
}

class Derived : Base
{
    new public static int add(int num1, int num2)
    {
        return num1 * num2;
    }

    public static void Main()
    {
        Derived d1 = new Derived();
        Console.WriteLine("Enter num1");
        d1.num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter num2");
        d1.num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(add(d1.num1, d1.num2));
    }
}