/*2.Create a C# program that prompts the user for three names of people and stores them in an array of 
Person-type objects. There will be two people of the Student type and one person of the Teacher type.
To do this, create a Person class that has a Name property of type string, a constructor that receives
the name as a parameter and overrides the ToString () method.
Then create two more classes that inherit from the Person class, they will be called Student and Teacher.
The Student class has a Study method that writes by console that the student is studying. The Teacher
class will have an Explain method that writes to the console that the teacher is explaining. Remember
to also create two constructors on the child classes that call the parent constructor of the Person class.
End the program by reading the people (the teacher and the students) and execute the Explain and Study methods.
*/

public class Person
{
    public static string Name;

    public Person(string Name)
    {
        
    }
    public override string ToString()
    {
        return base.ToString();
    }
}

public class Student:Person
{
    public void Study()
    {
        Console.WriteLine("Student is studing");
    }

    public Student(string Name): base (Name)
    {
      
    }
}

public class Teacher:Person
{
    public void Explain()
    {
        Console.WriteLine("Teacher is explaining");
    }

    public Teacher(string Name): base (Name)
    {
        


    }
}

public class TestStudentTeacher
{
    public static string[] array = new string[3];
    public static void Main()
    {
        Console.WriteLine("Student 1");
        Student s1 = new Student(Console.ReadLine());
        s1.Study();
        Console.WriteLine("Student 2");
        Student s2 = new Student(Console.ReadLine());
        s1.Study();
        Console.WriteLine("Teacher 1");
        Teacher t1 = new Teacher(Console.ReadLine());
        t1.Explain();
    }
}