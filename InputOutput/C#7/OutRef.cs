using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_7;

internal class OutRef
{
	public void Demo()
	{
		int x = 5;

		//x has to be initialized before being passed as a ref parameter
		//y has to be assigned before the method returns
		Test(ref x, out int y);
		Console.WriteLine($"x: {x}, y: {y}");  // output: x: 10, y: 10
	}

	//typical use
	//ref: modify existing value
	//out: return multiple values from a method
	public void Test(ref int a, out int b) {
		a = a + 5; //ref parameters may or may not be modified
		//var c = b; //out parameters cannot be read before being assigned
		b = 10; //out parameters must be assigned before the method returns

	}
}
