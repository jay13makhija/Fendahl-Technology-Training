// Strings are by default immutable in C# (ie once value is initialed it cannot be changed and new string is
// formed that has the point to the same pointer location)

using System;
using System.Text;
using System.Collections;

class CheckingImmutability
{
    public static void Main()
    {
        string s = "Jay";
        String s2 = " Makhija";   // String and strings are alias
        s = s + s2;  // Strings are concatinated at new location and is pointing at variable s
        Console.WriteLine(s);

        Console.WriteLine("Enter the StringBuilder string\n");        
        StringBuilder s3 = new StringBuilder(Console.ReadLine()); // To use the StringBuilder we need to using System.Text
        Console.WriteLine("This is a StringBuilder string \n");
        Console.WriteLine(s3);

    }
}