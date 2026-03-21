using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_6
{
	internal class StringInterpolation
	{
		public static void Demo()
		{
			var x = 2;
			var y = 3;

			//use """ to insert raw string literals
			var s = $"""The point "{x}, {y}" is {Math.Sqrt(x*x + y*y), 30:F3} from the origin""";
			//The point "2, 3" is              3.605551275463989 from the origin
			Console.WriteLine(s);

			s = $"""The point "{x}, {y}" is {Math.Sqrt(x * x + y * y),-30:F5} from the origin""";
			//The point "2, 3" is 3.605551275463989              from the origin
			Console.WriteLine(s);
		}
	}
}
