using InputOutput.Exercises.Partial_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_8;

internal class IndicesRanges
{
	public static void Demo() {
		int[] xs = [0, 10, 20, 30, 40];
		int last = xs[^0];
		Console.WriteLine(last);  // output: 40
		
		List<string> lines = ["one", "two", "three", "four"];
		var index = ^2;
		string prelast = lines[index];
		Console.WriteLine(prelast);  // output: three

		string word = "Twenty";
		Index toFirst = ^word.Length;
		char first = word[toFirst];
		Console.WriteLine(first);  // output: T

		int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		int start = 1;
		int amountToTake = 4;
		int[] subset = numbers[start..(start + amountToTake)];

		var margin = 1;
		int[] inner = numbers[margin..^margin];//starts from 1 and goes all the way to prelast

		string line = "one two three";
		int amountToTakeFromEnd = 5;
		Range endIndices = ^amountToTakeFromEnd..^0;//5th from last to the end
		string end = line[endIndices];//three
	}
}

//You can omit any of the operands of the..operator to obtain an open-ended range:
//a.. is equivalent to a..^0
//..b is equivalent to 0..b
//.. is equivalent to 0..^0