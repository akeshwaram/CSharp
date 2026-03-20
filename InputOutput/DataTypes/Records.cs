namespace InputOutput.DataTypes;

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
internal class Records
{
	public static void CreateRecords()
	{
		var p1 = new Person("Ashwin", 21);
		var p2 = p1 with { Age = 41 };
	}

}

public struct Vehicle
{
	public Vehicle() { }
}
