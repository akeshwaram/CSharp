namespace InputOutput.C_8;
internal class NullableReferenceType
{
	public static string? Demo()
	{
		//as we are creating a variable to accept null values, we need to explicitly declare it as nullable reference type by adding a question mark after the type
		string? message = null;

		//first time - compiler assumes it's an accident and hence shows a warning
		Console.WriteLine($"The length of the message is {message.Length}");

		//second time - compiler knows it's intentional, so the warning is suppressed
		Console.WriteLine($"The length of the message is {message.Length}");



		var list = new List<string>();
		var first = list.FirstOrDefault();//default for string is null
		return first; //let's compiler detect possible null related bugs - adds static checking for null references
	}
}
