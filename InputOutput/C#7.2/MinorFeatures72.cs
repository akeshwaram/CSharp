using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_7._2;

internal class MinorFeatures72
{
	public static void Demo() {

		//stackalloc initializers
		Span<int> numbers = stackalloc int[] { 1, 2, 3, 4, 5 };

		//Span<int> is a ref struct hence it cannot be boxed and cannot be used with heap-allocated arrays, it can only be used with stack-allocated arrays
		//object o = numbers; //this is an error - you cannot box a ref struct

		//this is incorrect because int[] is a heap-allocated array and cannot be used with stackalloc
		//int[] arr = stackalloc int[] { 1, 2, 3, 4, 5 };

		//regular heap-allocated array initialization
		int[] b = [1, 2];

		//reassign ref
		ref int x = ref numbers[0];
		x = ref b[1]; //reassigning ref to point to a different element in the span	
		
		
		ref int y = ref numbers[1];
		//condition (?) can also be used with refs
		ref int max = ref (x > y ? ref x : ref y);
	}

	//in parameters - passed by reference but read-only
	public void Print(in int x) {
		Console.WriteLine(x);
		//x = 10; //error: cannot modify an 'in' parameter
	}
}

//readonly struct - cannot be modified after creation, all fields must be initialized in the constructor, and all members must be readonly
//benefits: immutability and performance
public readonly struct Point { 
	public int X { get; }
	public int Y { get; }

	Point(int x, int y) { 
		X = x; 
		Y = y;
	}
}

