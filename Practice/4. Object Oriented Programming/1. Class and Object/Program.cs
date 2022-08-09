using System;

namespace OOPsBasics
{
    public class Cars
    {
        string color = "Red";
        string type = "Sports";
        public static void Main()
        {
            Cars MyObj = new Cars();
            Console.WriteLine(MyObj.color);
            Console.WriteLine(MyObj.type);
        }
    }
}