using InputOutput.Exercises.Partial_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_7;

//https://www.geeksforgeeks.org/c-sharp/local-function-in-c-sharp/
internal class LocalFunctions
{
	public static void Demo(int x, int y)
	{
		var a = x;
		var b = y;

		Console.WriteLine($"Sum is {Sum()}");
		Product(out int p);
		Console.WriteLine($"Product is {p}");

		int Sum() => x + y;

		//no public access modifier allowed for local functions
		void Product(out int p)
		{
			p = a * b;
		}
	}
}

