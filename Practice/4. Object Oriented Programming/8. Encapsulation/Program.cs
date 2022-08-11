using System;

class Informataion
{
    private int id;   //field
    public int Id     // property
    {
        get { return id; } 
        set { id = value; }
    }
    private string name;  // field
    public string Name    // property
    { 
        get { return name; }
        set { name = value; }     
    }
    private string company;   // field
    public string Company     // property
    { 
        get { return company; } 
        set { company = value; } 
    }

}

class Program
{
    public static void Main()
    {
        

        int num;
        Console.WriteLine("Enter number of People");
        num = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < num; i++)
        {
            Informataion info = new Informataion();
            
            Console.WriteLine("Enter Id");
            info.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            info.Name = Console.ReadLine();

            Console.WriteLine("Enter Company");
            info.Company = Console.ReadLine();

            Console.WriteLine("Name entered is " + info.Name + "\n");
            Console.WriteLine("Id entered is  " + info.Id + "\n");
            Console.WriteLine("Company entered is " + info.Company + "\n");

        }
        

    }
}