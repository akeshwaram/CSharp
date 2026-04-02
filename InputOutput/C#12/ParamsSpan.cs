using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_12;

//The params keyword in C# lets a method accept a variable number of arguments of the same type
internal class ParamsSpan
{
	public static int Sum(params int[] numbers)
	{
		int total = 0;

		if (numbers is null)
			return 0;

		foreach (var i in numbers)
		{
			total += i;
		}

		return total;
	}

	//C#12 allows you to use params with ReadOnlySpan<T>. This can be more efficient than using an array, especially for small collections of data
	public static int SumSpan(params ReadOnlySpan<int> numbers)
	{
		int total = 0;

		//span cannot be null. it's a value type (struct)
		//if (numbers is null)
		//	return 0;

		foreach (var i in numbers)
		{
			total += i;
		}

		return total;
	}

	public static void Demo()
	{
		Console.WriteLine(Sum(1, 2));
		Console.WriteLine(Sum(new int[] { 1, 2 }));

		int[] a = null;
		ReadOnlySpan<int> span = a.AsSpan();
		SumSpan(span);
	}
}
