using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace InputOutput.C_5;

internal class CallerInfoAttributes
{
	public string Name { get; set; } = DoSomething("Name Property");

	public static string DoSomething(string message,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0)
	{
		Console.WriteLine($"Message: {message}");
		Console.WriteLine($"Member Name: {memberName}");
		Console.WriteLine($"Source File Path: {sourceFilePath}");
		Console.WriteLine($"Source Line Number: {sourceLineNumber}");
		return message;
	}

	public CallerInfoAttributes()
	{
		Name = DoSomething("Constructor");
	}

	public void DoSomethingElse()
	{
		var s = Name;
	}

	public class Inner { }
}
