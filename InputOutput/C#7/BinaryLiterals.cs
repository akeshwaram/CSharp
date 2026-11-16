using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_7;

internal class BinaryLiterals
{
	//throw can be used in expression-bodied members statging C#7.0
	public string ReturnUpperCase(string s) => s != null? s.ToUpper() : throw new ArgumentNullException(nameof(s));

	public static void Demo() {
		int x = 0x0010; //binary literal for 2
		int y = 2;

		Console.WriteLine($"is x same as y? {x == y}");

		int a = 1_0000_00; //underscore can be used as a digit separator for better readability
		int b = 1000000;
		int c = 0b_1010; // underscore can be used at the beginning of the digit sequence
		//int d = _798798; //invalid; can only use underscore after a prefix

		Console.WriteLine($"is a same as b? {a == b}");

		//DEFAULT LITERAL EXPRESSIONS
		int m = default; //0
		string? s = default; //null

		int Sum(int i, int j) => default;


	}
}
