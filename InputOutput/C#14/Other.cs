using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_14;

internal class Other
{
	//field keyword
	public string Name {
		set { field = value + " (modified)" ; }
	}

	//simplied lambda expressions with modifiers
	delegate bool TryParse<T>(string text, out T result);
	//delegate bool TryParse2(string text);

	public void Demo()
	{
		//Func<string, bool> func = (string text) => true;
		
		TryParse<int> parse1 = (string text, out int result) => Int32.TryParse(text, out result);
		//the above can also be called without the types
		TryParse<int> parse2 = (text, out result) => Int32.TryParse(text, out result);

		//null-conditional assignment
		Person p = new Person();
		p?.Name = "name goes here";

		int[] numbers = [1, 2, 3, 4, 5];
		//implicit conversion of int[] to Span<int>
		Process(numbers);

		//prior to C#14 - we'd have to convert T[] to Span<T>
		Process(numbers.AsSpan<int>());
		Process(new Span<int>(numbers));


	}

	public void Process(Span<int> numbers)
	{
		numbers[0] = -99;
	}

}

internal class Other2
{
	//field keyword - use @ to indicate keyword
	private string field;
	public string Name
	{
		get { return @field; }
		set { @field = value + " (modified)"; }
	}
}

internal class Person
{
	public string Name;
}