using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_8;

internal class PatternMatchingEnhancements
{
	static int GetSourceLabel<T>(IEnumerable<T> source) =>
	source switch
	{
		Array arr => 1, //arr captures the value of source
		ICollection<T> collection => 2,
		_ => 3
	};

	static int GetSourceLabel2<T>(IEnumerable<T> source) =>
	source switch
	{
		Array _ => 1, //only checks if source is an Array, does not capture the value
		ICollection<T> _ => 2,
		_ => 3
	};

	static void NullChecks() {
		string? s1 = null;

		//this guarantees that no user-overloaded equality operator is called, and the check is done by reference equality
		//preferred to s1 == null
		if (s1 is null) {
			Console.WriteLine("s1 is null");
		}

		if (s1 is not null)
		{
			Console.WriteLine("s1 is not null");
		}
	}

}

