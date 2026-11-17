using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace InputOutput.C_14;

internal static class ExtensionMembers
{
	extension(string str)
	{
		public string AddBlah()
		{
			return $"{str}blah";
		}

		public string AddBlahAndSomethingElse(string somethingElse)
		{
			return $"{str}blah";
		}

		public bool IsLength5 => str?.Length == 5;
	}

	//extension block only the receiver type - str is missing
	extension(string) {
		public static int GetCount(string str) {
			return str.Length;
		}
	}
}
