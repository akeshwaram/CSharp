using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_12;

internal class MemorySpan
{
	public static int Sum(Memory<int> numbers)
	{
		Span<int> span = numbers.Span;

		var total = 0;
		foreach (var i in span)
		{
			total += i;
		}

		return total;
	}

	//Memory<T> is the safe, general-purpose version of Span<T>. It can be used on the heap and can be stored in fields
	//Span<T> is a ref struct, which means it can only be used on the stack and cannot be stored in fields or used with async methods
	public static void Demo()
	{
		Memory<int> memo = new int[] { 1, 2, 3, 4, 5 };
		Console.WriteLine(Sum(memo));
	}
}
