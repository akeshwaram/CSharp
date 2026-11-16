using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_7._2;

internal class ReadOnlySpan
{
	public static void Demo() {
		//create a mutable view over memory
		Span<int> arr = stackalloc int[5];
		arr[0] = 1;
		int[] temp = [1, 2, 3, 4, 5, 6];
		arr = temp.AsSpan(0, 2);

				//create an immutable view over memory
		ReadOnlySpan<int> readOnlyArr = [1, 2, 4, 6];
		var x = readOnlyArr[0];
		//readOnlyArr[1] = 5; //error - cannot modify
	}
}


public class Test {
	public void Demo() {
		
	}

}