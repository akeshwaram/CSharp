using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_8;

internal interface Ilogger
{
	public void LogWarning(string warning);

	public void LogError(string error) {
		Console.WriteLine(error);
	}
}

public class MyLogger: Ilogger
{
	public void LogWarning(string warning)
	{
		Console.WriteLine(warning);
	}
}

public class defaultInterfaceMembers
{
	public static void Demo()
	{
		var logger = new MyLogger();
		//logger.LogError("This is an error"); //error because LogError is not implemented in MyLogger
		((Ilogger)logger).LogError("This is an error");
		logger.LogWarning("This is a warning");

		Ilogger ilogger = logger;
		ilogger.LogError("This is an error"); // works because ilogger is of type Ilogger reference, which has a definition of LogError

		//in the future if we want to a new method to the Ilogger interface, we can add it with a default implementation
		//and it will not break the existing implementations of the interface
	}
}
