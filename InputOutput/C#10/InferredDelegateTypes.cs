using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_10;

internal class InferredDelegateTypes
{
	//Compiler infers what type of delegate to use based on how the lambda is used
	public void Demo() {

		var f = (int a, int b) => a + b;
		
		//the above lambda is converted into the func below; similarly for actions
		Func<int, int, int> f2 = (int a, int b) => a + b;

		var a = (int a, int b) => Console.WriteLine(a + b);

		//similary for Actions
		Action<int, int> a2 = (int a, int b) => Console.WriteLine(a + b);




	}
}
