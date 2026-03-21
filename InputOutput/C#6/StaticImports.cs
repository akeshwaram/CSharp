using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
using static InputOutput.C_5.CallerInfoAttributes;

namespace InputOutput.C_6;

internal class StaticImports
{
	public void Demo() {
		double sqr = Sqrt(10);
		DoSomething("This method demonstrates static imports");
		//this method is not available because it is not static
		//DoSomethingElse("");
		var i = new Inner(); //static imports also import nested types - both static and non-static
	}
}
