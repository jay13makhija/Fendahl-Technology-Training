using System.Text;

class Sample
{
    public static void Main()
    {
        Console.WriteLine("Enter Hello World");
        StringBuilder s1 = new StringBuilder(Console.ReadLine());

        Console.WriteLine("Your Entered String is ");
        for (int i = 0; i < s1.Length; i++)   
        {
            Console.Write(s1[i]);
        }

        var str = s1.ToString();     // To make a string from stringbuilder object

        s1.Append(str);                         // To add at the end of StringBuilder
        Console.WriteLine("\n" + s1);

        s1.AppendLine(str);                    //To add at the end of StringBuilder and line break
        Console.WriteLine(s1);

        s1.Remove(0, 3);                        // Remove 3 chars from 0 index 
        Console.WriteLine(s1);

        s1.Replace("Hello", "Jay");           // To replace "Hello" with "Jay"
        Console.WriteLine(s1);

    }
}