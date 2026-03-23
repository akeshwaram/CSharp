using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_7._1;

internal class MinorFeatures71
{
	public void Demo() {
		//inferred tuple names
		var name = "ashwin";
		var age = 35;

		var person = (name, age); //tuple names inferred from variable names
		Console.WriteLine($"{person.name} {person.age}");
	}

	//use pattern matching with generics
	void Print<T>(T value)
	{
		if (value is int i)
		{
			Console.WriteLine($"Integer: {i}");
		}
		else if (value is string s)
		{
			Console.WriteLine($"String: {s}");
		}
		else
		{
			Console.WriteLine("Unknown type");
		}
	}

	//can use switch expressions with generics
	int PrintWithSwitch<T>(T value)
	{
		return value switch
		{
			> 5 => 1,
			_ => 0
		};
	}
}
