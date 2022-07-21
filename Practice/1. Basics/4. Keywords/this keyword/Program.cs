using System;

class Test
{
    private string name;
    private int id, salary;

    public Test(string name, int id, int salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public void Print()
    {
        Console.WriteLine("Name is " + name  + "\nId is " + id  + "\nSalary is " + salary);
    }

    public static void Main()
    {
        Test t1 = new Test("Jay", 13, 20000);
        t1.Print();
    }
}