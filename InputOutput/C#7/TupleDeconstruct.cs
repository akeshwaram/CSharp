using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_7;

internal class TupleDeconstruct
{
	public static void Demo()
	{
		double[] values = [1, 2, 3];
		var t = Tally(values);

		var (countField, sumField) = Tally(values); // deconstructing the tuple into separate variables
		
		//System.ValueTuple is the preferred type today - supports name fields, better syntax and readability 
		Console.WriteLine($"count is {t.Item1} sum is {t.Item2}");
		Console.WriteLine($"count is {t.count} sum is {t.sum}");
		Console.WriteLine($"count is {countField} sum is {sumField}");

		var person1 = (name: "Ashwin", age: 35); //value tuple
		var person2 = Tuple.Create("Ashwin", 35); //ref tuple - older version
	}

	public static (int count, double sum) Tally(double[] values)
	{
		var count = 0;
		var sum = 0.0;
		
		foreach (var val in values)
		{ 
			count++;
			sum += val;
		}

		return (count, sum);
	}
}
