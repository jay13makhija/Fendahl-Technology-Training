using System;

namespace Construct
{
    class Students
    {
        public int Id, RollNo;
        public string Name;

        //Constructor
        public Students()
        {
            Console.WriteLine("Enter student's ID in Integer");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student's RollNo in Integer");
            RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student's Name");
            Name = Console.ReadLine();
        }

        public static void Main()
        {
            Students obj = new Students();
            Console.WriteLine("\n" + "Id of the student is " + obj.Id);
            Console.WriteLine("RollNo of the student is " + obj.RollNo);
            Console.WriteLine("Name of the student is " + obj.Name);
        }
    }
}