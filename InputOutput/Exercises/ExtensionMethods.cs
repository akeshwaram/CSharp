namespace InputOutput.Exercises;
internal static class ExtensionMethods
{
	//extension method - add a new method to a class; has to be static method inside a static class
	public static int WordCount(this string str)
	{
		if (String.IsNullOrEmpty(str)) return 0;

		return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
	}
}
