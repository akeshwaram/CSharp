using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_7._3;

public class Animal { }
internal class GenericConstraints<TClass> where TClass: class
{
	//T must be a reference type
	void Process1<T>() where T: class
	{ 
	}

	//T must be a value type (struct) - int, double, DateTime, etc. are allowed
	void Process2<T>() where T: struct
	{
	}

	//T must have a parameterless constructor
	void Process3<T>() where T : new()
	{ }

	//T must implement IDisposable
	void Process4<T>() where T : IDisposable
	{ }

	//T must inherit from Animal
	void Process5<T>() where T : Animal
	{ }

	//T1 must be a reference type with a parameterless constructor, and T2 must implement IDisposable
	void Process6<T1,T2>() where T1: class, new() where T2 : IDisposable
	{ }

	//introduced in 7.3
	//T must be an unmanaged type - a struct that contains no reference types
	void Process7<T>() where T : unmanaged
	{ }

	//T must be an enum type
	void Process8<T>() where T : Enum
	{ }

	//T must be a delegate type
	void Process9<T>() where T : Delegate
	{ }
}
