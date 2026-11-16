using System.Buffers.Text;

namespace InputOutput.DataTypes;

//record - reference based, immutable, value-based equality
//record struct - value based, mutable, value-based equality
//readonly record struct - value based, immutable, value-based equality

public record Person
{
	public string Name { get; set; }
	public int Age { get; set; }

	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}
}

public record struct Point(int X, int Y);

public readonly record struct ReadOnlyPoint(int X, int Y);

internal class Records
{
	public static void CreateRecords()
	{
		var p1 = new Person("Ashwin", 21);
		p1.Age = 22;
		var p2 = p1 with { Age = 41 };
	}

}

public struct Vehicle
{
	public Vehicle() { }
}
