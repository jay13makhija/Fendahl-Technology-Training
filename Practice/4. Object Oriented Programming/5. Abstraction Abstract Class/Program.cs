using System;

public abstract class Shape
{
    public abstract void Draw();
}

public class Rectangle: Shape
{
    public override void Draw()
    {
        Console.WriteLine("This is a Rectangle");
    }
}

public class Square: Shape
{
    public override void Draw()
    {
        Console.WriteLine("This is a Square");
    }
}

public class Circle: Shape
{
    public override void Draw()
    {
        Console.WriteLine("This is a Circle");
    }
}

public class Triangle: Shape
{
    public override void Draw()
    {
        Console.WriteLine("This is a Triangle");
    }
}

public class Test
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Draw();

        Square square = new Square();
        square.Draw();

        Circle circle = new Circle();
        circle.Draw();

        Triangle triangle = new Triangle();
        triangle.Draw();
    }
}