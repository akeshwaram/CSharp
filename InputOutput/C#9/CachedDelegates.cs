using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_9;

internal class CachedDelegates
{
	public static int Square(int x) => x * x;

	public void Demo() {
		Func<int, int> f = Square;

		foreach (var i in new int[] { 1, 2, 3 })
		{
			//here, since Square is static, the same delegate instance is reused instead of creatng new one every time
			Console.WriteLine(f(i));
		}
		
	}
}
