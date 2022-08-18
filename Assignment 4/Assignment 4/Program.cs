/*                                      Assignment 4
Consider following method overload : 
void Add(string s1, object a1)
void Add(object a1, string s1)

Method call :
Add(null, null); // Which method gets called ? 
if you can call any of the overloaded versions of the method or get an error.
Justify the compiler behavior.*/

using System;
public class Sample
{
    public static object a1;
    public static void Add(string s1, object a1)
    {
        
    }
    public static void Add(object a1, string s1)
    {
        
    }
}

public class Test: Sample
{
    
    public static string s1 = "Sample";
    public static void Main()
    {
        Add(null, null);
    }
}

/*
Since both the values can be implicitly converted the compiler gets confuesd and this error 
occurs.

There are majorly 2 solutions

1) To not use overloading as the parameters received are same but just in different order.
   We can cahnge some implimentation in the methods and keep a single one of them.

2) #pragma warning disable CS8604 // Possible null reference argument.
        Add(null as string, null as object);
   #pragma warning restore CS8604 // Possible null reference argument.
   This targets a particular method to pass parameters in specific.
*/


// If we do not pass null values the overloading works as follows

/*using System;
public class Sample
{
    public static object a1 = "Jay";
    public static void Add(string s1, object a1)
    {
        Console.WriteLine(s1 + " " + a1);
    }
    public static void Add(object a1, string s1)
    {
        Console.WriteLine(a1 + " " + s1);
    }
}

public class Test : Sample
{

    public static string s1 = "Sample";
    public static void Main()
    {
        Add(s1, a1);
        Add(a1, s1);
    }
}*/