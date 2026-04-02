using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace InputOutput.C_12;

internal class OverloadResolutionPriority
{
	[OverloadResolutionPriority(1)]
	public void Print(string s)
	{
		Console.WriteLine("String overload");
	}

	[OverloadResolutionPriority(0)]
	public void Print(object o)
	{
		Console.WriteLine("Object overload");
	}

	public void Demo()
	{
		Print("Hello"); //calls string overload because it has higher priority
		Print(123); //calls object overload because it has lower priority and int can be boxed to object
					//if Print(object) were to be removed, Print(123) would be an error because there would be no overload that can accept an int argument and no implicit conversions exists to convert int to string
	}
}
