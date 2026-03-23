using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_7._3;

//Improved method overload resolution when using "in"
//Compiler prefers by-value overload when "in" is not specified
internal class InMethodOverload
{
	public void Demo() {
		int a = 10;
		Print(a);
		Print(in a);
	}

	public void Print(int a) {
		Console.WriteLine($"printing by value: {a}");
	}

	public void Print(in int a)
	{
		Console.WriteLine($"Printing by in: {a}");
	}
}
