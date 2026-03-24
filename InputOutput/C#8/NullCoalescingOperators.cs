using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_8;

internal class NullCoalescingOperators
{
	public void Demo() {
		string s1 = null;
		string s2 = "test";

		var result = s1 ?? s2; //"test" - if s1 is null, then s2 is returned
		s1 = "random";

		result = s1 ?? s2; //"random" - if s1 is not null, then s1 is returned

		s1 ??= "blah"; //"random" if s1 is null, then assign "blah" to s1, otherwise do nothing
		s1 = null;
		s1 ??= "blah"; //"blah" if s1 is null, then assign "blah" to s1, otherwise do nothing
	}
}
