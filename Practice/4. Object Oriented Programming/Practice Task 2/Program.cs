/*Create a new C # project with three classes plus another class to test the 
  logic in your code. The main classes of the program are the following classes:
•	Person
•	Student
•	Professor
The Student and Teacher classes inherit from the Person class.
The Student class will include a public Study() method that will write I'm studying on the
screen.
The Person class must have two public methods Greet() and SetAge(int age) that will assign the
age of the person.
The Teacher class will include a public Explain() method that will write I'm explaining on the
screen.
Also create a public method ShowAge() in the Student class that writes My age is: x years old
on the screen.
You must create another test class called StudentProfessorTest with a Main method to do the
following:
•	Create a new Person and make him say hello
•	Create a new Student, set an age, say hello, and display her age on the screen.
•	Create a new Teacher, set an age, say hello and start the explanation
*/

using System;

public class Person
{
    public void Greet()
    {
        Console.WriteLine("Hello!!");
    }
    public int SetAge(int age)
    {
        return age;
    }
    
}
public class Student:Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }
    public void ShowAge(int age)
    {
        Console.WriteLine("My age is: " + age + " years old");
    }
}
public class Professor:Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining");
    }
}

public class StudentProfessorTest
{
    public static void Main()
    {
        Person person = new Person();
        person.Greet();
        Student student = new Student();
        Console.WriteLine("Enter the age of student");
        int age = Convert.ToInt32(Console.ReadLine());
        student.SetAge(age);
        student.Greet();
        student.ShowAge(age);
        Professor teacher = new Professor();
        Console.WriteLine("Enter the age of teacher");
        age = Convert.ToInt32(Console.ReadLine());
        teacher.SetAge(age);
        teacher.Greet();
        teacher.Explain();
    }
}