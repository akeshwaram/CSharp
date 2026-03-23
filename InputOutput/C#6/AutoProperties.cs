using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_6;

internal class Person
{
	//C#6 allows us to initialize property directly in the property declaration
	public int Age { get; } = 25;

	//added support for read-only properties - can still be initialized in the constructor, but can't be modified after that
	public string LastName { get; }

	public string FirstName { get; } = "Ashwin";

	public Person() {
		//constructor overrides initializer
		FirstName = "Overriden";
	}
	public Person(int age, string firstName, string lastName) {
		LastName = lastName;
	}

	public void Demo()
	{
		var p = new Person(25, "dfsd", "dfsa");
		//this will cause a compile error, because LastName is read-only
		//p.LastName = ""; 
	}
}
