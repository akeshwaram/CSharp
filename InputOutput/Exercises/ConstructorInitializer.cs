using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.Exercises;

//A constructor initializer in C# is a way for one constructor to call another constructor in the same class
//or the base class before its own body runs.
internal class ConstructorInitializer : BaseClass
{
	public string Name { get; }
	
	public ConstructorInitializer() : this("Default") {
		//calls the constructor that takes a string parameter, passing "Default" as the argument
	}

	public ConstructorInitializer(string name) :base() {
		Name = name;
	}
}

public class BaseClass { 

}
