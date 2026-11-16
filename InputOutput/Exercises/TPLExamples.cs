using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.Exercises;

internal class TPLExamples
{
	public static void Demo()
	{
		int[] numbers = [1, 2, 3, 4, 5];
		var total = 0;
		
		Parallel.ForEach(numbers, n =>
			total += n);

		Console.WriteLine($"Total using Parallel.ForEach is {total}");

		total = 0;
		numbers.AsParallel().ForAll(n => Interlocked.Add(ref total, n));
		Console.WriteLine($"Total using PLINQ is {total}");
	}
}
