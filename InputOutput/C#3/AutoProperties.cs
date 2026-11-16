using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_3;

internal class Person
{
	//creates a private backing field and public getter/setter for it
	public int Age { get; set; }

	//required keyword forces the property to be initialized during object creation
	//Person p = new Person() => will cause compile-time error because FirstName is not initialized
	public required string FirstName {
		get; 
		set { 
			field = !string.IsNullOrEmpty(value) ? value: throw new ArgumentException("First name cannot be null or empty");
		}
	}
}

internal interface IAutoProperties
{
	int MyProperty { get; set; }
}

public class AutoPropertiesWithInterface : IAutoProperties
{
	public int MyProperty { get; set; }
}
