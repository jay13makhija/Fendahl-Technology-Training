/*                                      Assignment 3
 
Consider a base class MyClassA { }
with few instance methods inside & a derived class of MyClassA is class MyClassB { } 

Class MyClassA { }
has only 1 constructor which is parameterized & MyClassB has no user defined constructor. 

Are we able to create an instance of the class MyClassB with following statement in main method 

MyClassB mb1 = new MyClassB();

if yes / no then why ? */

//  Answer is NO

using System;
public class MyClassA
{
    private void Sample()
    {
        Console.WriteLine("Inside Sample");
    }
    public MyClassA(int num)
    {
        Console.WriteLine(num);
    }
    /*public MyClassA()                               // Solution 1 to the problem
    {

    }*/
}

public class MyClassB : MyClassA
{
    /*public MyClassB(int num) : base(num)
    {                                                 // Solution 2 of the problem

    }*/
    public static void Main()
    {
        /*int num = 10;*/
        MyClassB mb1 = new MyClassB(/*num*/);
    }
}