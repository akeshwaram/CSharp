using System;
using System.Runtime.ConstrainedExecution;
using System.Text;
using GenericsAlias = System.Collections.Generic;

namespace InputOutput.Exercises;

internal class Misc
{
	#pragma warning disable CS0168 // Variable is declared but never used
	public void Demo() { 
		//using a namespace alias
		var names = new GenericsAlias.List<string>();

		
		int unusedVariable;
	}
#pragma warning restore CS0168 // Variable is declared but never used

	//safe vs unsafe code
	//Safe code is the normal C# you write every day. It is managed by the.NET runtime(CLR),
	//protected by type safety and memory safety, free from direct memory manipulation
	//Unsafe code is a special mode in C# that allows you to write code that can directly manipulate memory using pointers.
	//Unsafe keyword is allowed for use with methods, structs, and blocks of code
	//now we can use Span<T>, Memory<T>, and Stackalloc to get pointer-like power without having to use unsafe code
	public void UnsafeDemo() {
		unsafe {
			int x = 10;
			int* p = &x; //pointer to x
			Console.WriteLine(*p); //dereference pointer to get value of x
		}
	}

	//fixed can only be used inside an unsafe context and inside a struct
	//unsafe code is mainly used for interop purposes
	public unsafe struct Example {
		public fixed int data[10]; 
	}

}
