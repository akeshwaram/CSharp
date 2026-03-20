//Covariance and contravariance describe how types relate to each other when using generics or delegates.
//They determine whether derived types can be substituted for base types (or vice versa).
//Page 143 - C# in Depth, 4th edition
//Variance can be declared only in interfaces and delegates.

namespace InputOutput.C_4;
internal class Covariance
{
	public void CovarianceDemo()
	{
		//prior to variance, we'd need an explicit cast from string to object
		List<string> strings = ["a", "b", "cdefg", "hij"];

		//not allowed - List<T> is not covariant - it's not read-only; you can add, remove, etc.
		//List<object> list = strings;

		//works because of covariance - ienumerable guarantees read-only behavior
		IEnumerable<object> enumerable = strings;
	}

	public void ContravarianceDemo()
	{
		//if a function can handle an Object, then it can also handle a string
		Action<Object> act = o => Console.WriteLine("Object");
		Action<string> strAction = act;


	}
}
