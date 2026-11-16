using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_4;

internal class DynamicType
{
	public void Demo() {
		object obj = 1;
		dynamic dyn = new List<string>();

		//error
		//obj += 3;

		//OK during compilte, but exception at runtime
		dyn += 3;


		//A compiler error is reported for expression obj + 3.
		//no error is reported for dyn + 3. The expression that contains dyn isn't checked at compile time because the type of dyn is dynamic.
		//obj += 2; => static binding - compile decides everything at compile time
		dyn += 3; // dynamic binding => at runtime figure out what + means for this object

		Console.WriteLine($"obj type is {obj.GetType()}");
		Console.WriteLine($"dyn type is {dyn.GetType()}");
		Console.WriteLine($"obj value is {obj}");
		Console.WriteLine($"dyn value is {dyn}");

		//Runtime Polymorhism is also a kind of dynamic binding
	}
}
