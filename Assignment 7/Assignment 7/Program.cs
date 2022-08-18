/*                                     Assignment 7
--> Consider following method implemetations : 
	void Add(int a, int b)
	void Add(double a, double b)
	void Add(int a, double b)


--> Understand practically, which method will hit by the following calls
	1. Add(10, 20)
	2.Add(20, 20.30)
	3.Add(30.3, 10.0*/

using System;

class A
{
	void Add(int a, int b)
	{ Console.WriteLine(a + b); }
	void Add(double a, double b)
	{ Console.WriteLine(a + b); }
	void Add(int a, double b)
	{ Console.WriteLine(a + b); }

	public static void Main()
	{
		A a = new A();
		a.Add(10, 20);
		a.Add(20, 20.30);
		a.Add(30.3, 10.0);
	}
}