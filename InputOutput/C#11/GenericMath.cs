using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace InputOutput.C_11;

//INumber<T> was introduced in C#11 to enable writing generic, type-safe math code that works across all numeric types
internal class GenericMath
{
	//you can now write arithmetic functions once and use them with various types
	public T Add<T>(T a, T b) where T : INumber<T>
	{
		return a + b;
	}

	public void Demo() {
		Console.WriteLine(Add(1,1));//works with int
		Console.WriteLine(Add(1.5, 1.3)); //works with double
		Console.WriteLine(Add(1.5, 1)); //converts 1 to double
	}
}

//static abstract interface members - introduced mainly to support generic math
//designed to be used with generics. otherwise they are not very useful
interface IMath<T>
{
	//every type implementing IMath must provide a static Add method
	static abstract T Add(T a, T b);
}

//MyInt implements the interface IMath<T> where T is MyInt itself
public struct MyInt : IMath<MyInt>
{ 
	public int Value { get; set; }
	public static MyInt Add(MyInt a, MyInt b)
	{
		return new MyInt { Value = a.Value + b.Value };
	}
}

public static class MathUtils {
	//now T can be int, double, MyInt, etc.
	static T AddTwo<T>(T a, T b) where T : IMath<T>
	{
		return T.Add(a, b);
	}
}