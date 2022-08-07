using System;

class String_functions
{ 
    public static void Main()
    {
        string s, s2;
        Console.WriteLine("Enter a String\n");
        s = Console.ReadLine();
        Console.WriteLine("Enter another String\n");
        s2 = Console.ReadLine();

        Console.WriteLine("The String concatination is\n");
        Console.WriteLine(s + s2);

        string s3 = string.Concat(s, s2);
        Console.WriteLine(s3);

        Console.WriteLine($"\nthis is first string {s} \nthis is the second string {s2}");

        Console.WriteLine("\nThe length of the first sting is " + s.Length + "\n");

        Console.WriteLine("Are the strings equal ?\n");
        Boolean Same = s.Equals(s2);
        Console.WriteLine(Same);

        Console.WriteLine("\nThe first string in lower case is" + s.ToLower());
        Console.WriteLine("\nThe first string in upper case is" + s.ToUpper());

        Console.WriteLine("\nRemoving 3 chars from 0 index in first string " + (s.Remove(0, 3)));

        Console.WriteLine("Enter a String to Split\n");
        string s4 = Console.ReadLine();
        string[] sub = s4.Split(" ");
        foreach (var sub2 in sub)
        { Console.WriteLine(sub2); }

        Console.WriteLine("Enter String to Trim\n");
        string s5 = Console.ReadLine();
        Console.WriteLine("Triming the starting\n");
        Console.WriteLine(s5.TrimStart());
        Console.WriteLine("Triming the ending\n");
        Console.WriteLine(s5.TrimEnd());
        Console.WriteLine("Triming the start as well as the end\n");
        Console.WriteLine(s5.Trim());

        Console.WriteLine("Compairing 2 Strings\nEnter String 1");
        string s6 = Console.ReadLine();
        Console.WriteLine("Enter String 2");
        string s7 = Console.ReadLine();
        Console.WriteLine(s6.CompareTo(s7));
    }
}