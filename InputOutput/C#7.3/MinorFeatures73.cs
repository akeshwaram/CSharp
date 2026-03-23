using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace InputOutput.C_7._3;

internal class MinorFeatures73
{
	//we can now add attributes to the backing field in auto-properties
	[property:Obsolete] //earlier we could only add attributes to the property,
	[field: NonSerialized] //now we can also add attributes to the backing field of an auto-property
	public int Age { get; set; }


	public static void Demo() {
		//You can test == and != with tuple types.
		var t1 = (name: "ashwin", city: "hyderabad");
		var t2 = (name: "ashwin", city: "hyderabad");

		Console.WriteLine($"are tuples equal? {t1 == t2}");
		Console.WriteLine($"are tuples not equal? {t1 != t2}");
	}
}
