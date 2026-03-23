using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_6;

internal class NullPropogation
{
	public static void Demo()
	{
		string s = null;
		Console.WriteLine(s?.Length); //this will print nothing instead of throwing a NullReferenceException

		int[] array = null;
		Console.WriteLine(array?[1]); //this will print nothing instead of throwing a NullReferenceException

		var dict = new Dictionary<string, string>();
		dict = null;
		Console.WriteLine(dict?["key"]); //this will print nothing instead of throwing a NullReferenceException

	}
}
