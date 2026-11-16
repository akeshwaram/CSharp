using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_8;

internal class StaticLocalFunctions
{
	public void Demo(int x, int y)
	{
		var a = x;
		var b = y;
		
		Console.WriteLine($"Sum is {Sum()}");
		Product(out int p);
		Console.WriteLine($"Product is {p}");

		int Sum() => x + y;

		//a static local function cannot access the local variables of the containing method, it can only access the parameters of the containing method
		static void Product(out int p)
		{
			p = 5;
			Console.WriteLine();
		}

		//local functions can also have async, unsafe, and extern modifiers
		async void AsyncLocalFunction()
		{
			await Task.Delay(1000);
			Console.WriteLine("Async local function");
		}
	}
}
