/*                                         Assignment 2:

Consider Class Demo1 with instance methods D1() and D2().

The class Demo1 has only 1 user-defined constructor and it is marked as private. 

Considering the above situation, we can not instantiate the class Demo1 in any other 
class and also can not be able to access its method. 

You are allowed to modify the class but do not add a constructor, do not inherit the
class Demo1 &also do not modify the existing constructor.

Try to find the solution to access the instance methods D1 and D2.*/

using System;

public class Demo1
{
    public static void D1()
    {
        Console.WriteLine("This is D1");
    }
    public static void D2()
    {
        Console.WriteLine("This is D2");
    }

    private Demo1()
    {
        Console.WriteLine("This is constructor");
    }
}

public class Main_Class
{
    public static void Main()
    {
        Demo1.D1();
        Demo1.D2();
    }
}