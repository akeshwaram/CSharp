using System.Data.Common;

namespace InputOutput.DataTypes;

internal class Tuples
{
	public static (string, string) CreateAndReturnTuple()
	{
		var person = ("Ashwin", "Hyderabad");
		return person;
	}

	public static (string Name, string Location) CreateNamedTuple()
	{ 
		var person = (Name: "Ashwin", Location: "Hyderabad");
		return person;
	}
	public static void PrintTuple()
	{
		var tuple = CreateAndReturnTuple();
		Console.WriteLine($"Name: {tuple.Item1}, Location: {tuple.Item2}");

		var namedTuple = CreateNamedTuple();
		Console.WriteLine($"Name: {namedTuple.Name}, Location: {namedTuple.Location}");
	}
}
