namespace InputOutput.C_8;
internal class NullableReferenceType
{
	public static string? Demo()
	{
		var list = new List<string>();
		var first = list.FirstOrDefault();//default for string is null
		return first; //let's compiler detect possible null related bugs - adds static checking for null references
	}
}
