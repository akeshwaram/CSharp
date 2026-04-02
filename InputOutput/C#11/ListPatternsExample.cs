using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_11;

internal class ListPatternsExample
{
	public static void Demo()
	{
		int[] numbers = [1, 2, 3, 5];

		if (numbers is [1, .., 5])
		{
			Console.WriteLine("numbers starts with 1 and ends with 5");
		}

		if (numbers is [1, _, 5])
		{
			Console.WriteLine("numbers starts with 1 and ends with 5 and has exactly three elements");
		}
		else
		{
			Console.WriteLine("Check numbers array");
		}

		if (numbers is not int[])
		{
			Console.WriteLine("numbers is not an int array");
		}
		else {
			Console.WriteLine("numbers is an int array");
		}
	}

}
