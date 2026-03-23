using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InputOutput.C_7;

internal class RefLocalRefReturn
{
	private static readonly int[] numbers = [1, 30, 7, 1557, 381, 63, 1027, 2550, 511, 1023];
	
	public static void Demo() {
	
		var a = 10;
		ref var b = ref a;
					
		Console.WriteLine($"a is {a} b is {b}");
		a = 7;
		Console.WriteLine($"a is {a} b is {b}");

		void Display(int[] s) => Console.WriteLine(string.Join(" ", s));

		int[] xs = [0, 0, 0];
		Display(xs);

		ref int element = ref xs[0];
		element = 1;
		Display(xs);

		element = ref xs[^1];//last element of the array
		element = 3;
		Display(xs);

		//readonly - element2 points to element but cannot be used to change the value of element
		ref readonly int element2 = ref element;

		//element2 = 5 //error because element2 is readonly

		ref int max = ref GetReferenceToMax();
		max = 0; //changes array to [1, 30, 7, 0, 381, 63, 1027, 0, 511, 1023]

	}

	public static ref int GetReferenceToMax()
	{
		ref int max = ref numbers[0];
		for (int i = 1; i < numbers.Length; i++)
		{
			if (numbers[i] > max)
			{
				max = ref numbers[i];
			}
		}
		return ref max;
	}
}
