using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_12;

internal class PrimaryConstructor(string name, int age)
{
	public string Name { get; set; } = name;
	public int Age { get; set; } = age;

	//other constructors must call the primary constructor
	public PrimaryConstructor(string name, int age, int x): this(name, age)
	{
		
	}

	//other constructors must call the primary constructor
	public PrimaryConstructor() : this("", default){ }
}
