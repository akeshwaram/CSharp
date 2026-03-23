using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_9;

internal class Person
{
	public int Age { get; } = 25;

	public string LastName { get; }

	//init-only properties - can be initialized during object creation or in the constructor, but can't be modified after that
	public string FirstName { get; init; } = "sdfsd";

	public Person() {
		LastName = "sdfs";
		FirstName = string.Empty;
	}

	public void Demo()
	{
		var p = new Person() { 
			FirstName = "dfds"
		};

		//this will cause a compile error, because FirstName is marked init
		//p.FirstName = "";
		
		//p.FirstName = ""; 
	}
}
