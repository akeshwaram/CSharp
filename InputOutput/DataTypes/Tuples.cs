using System.Data.Common;

namespace InputOutput.DataTypes;

internal class Tuples
{
	public static (string Name, string location) CreateAndReturnTuple()
	{
		var person = (name: "Ashwin", location: "Hyderabad");
		
		return person;
	}

	public static void PrintTuple()
	{
		var person = CreateAndReturnTuple();
		Console.WriteLine(person.Name);

		var random = (21, DateTime.Now);
		Console.WriteLine(random.Item1);
	}
}
