/*Create a C# program that implements an Vehical interface with two methods, one for Drive
of type void and another for Refuel of type bool that has a parameter of type integer with the
amount of gasoline to refuel. Then create a Car class with a builder that receives a parameter with
the car's starting gasoline amount and implements the Drive and Refuel methods of the car.

The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0.
The Refuel method will increase the gasoline of the car and return true.

To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program and
ask the user for an amount of gasoline to refuel, finally execute the Drive method of the car.*/

using System;


public interface Vehical
{
    public void Drive();
    public bool Refuel(int gasoline);

}

public class Car:Vehical
{
    public int gasoline
    {
        get;
        set;
    }

    public void Drive()
    {
        if(gasoline > 0)
            Console.WriteLine("Car is Driving");
    }

    public bool Refuel(int gasoline2)
    {
        gasoline += gasoline2;
        return true;
    }
}

public class Test
{
    public static void Main()
    {
        Car car = new Car();
        car.gasoline = 0;
        car.gasoline = Convert.ToInt32(Console.ReadLine());
        car.Refuel(car.gasoline);
        car.Drive();

    }
}