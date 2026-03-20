namespace InputOutput;

//Generics allow you to write classes and methods that work with any data type while maintaining compile-time type safety
internal class Generics
{
	public static List<T> CopyAtMost<T>(List<T> input, int maxElements)
	{
		var list = new List<T>();
		var numToCopy = Math.Min(input.Count, maxElements);
		list = input.Take(numToCopy).ToList();

		//_ = new Tuple<string, int, string, string, string, string, string,string>("a", 10, "c", "a","a", "a", "a","a");
		//_ = Tuple.Create("a", "a", "a", "a", "a", "a", "a", "a");

		//before Generics was introduced, we used to use ArrayList
		ArrayList listOfStrings = new ArrayList();
		listOfStrings.Add("one");
		listOfStrings.Add(5);
		var firstString = (string?)listOfStrings[0];
		//nullable reference types are mainly for static code analysis and warnings - they don't prevent runtime null reference exceptions
		//string means the value should not be null. string? means it can be null.

		return list;
	}

	public static List<T> RefineList<T>(List<T> list) where T : IFormattable
	{

		var final = new List<T>
		{
			list.First()
		};

		var x = new List<decimal> { 1 };
		var t = typeof(List<decimal>);

		return final;
	}

	public static List<T> RefineList<T, T1>(List<T> list) where T : IFormattable where T1 : IFormattable
	{

		var final = new List<T>
		{
			list.First()
		};

		return final;
	}

	public static T LastOrDefault<T>(IEnumerable<T> source)
	{
		T ret = default(T);
		foreach (T item in source)
		{
			ret = item;
		}
		return ret;
	}
}

public class Box<T> where T : IList
{
	public Box()
	{
		var a = new List<T>();
	}

	public T GetOne<T>()
	{
		return default(T);
	}
}

public static class Extension
{
	public static string ToString(this int i)
	{
		return (i + 5).ToString();
	}
}
