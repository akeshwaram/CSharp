namespace InputOutput.C_3;
internal class ActionFunc
{
	//use Action when there is no return value
	//Contravariant on input parameters
	//limit 16 parameters
	Action<string> printNameInUpperCase = nameStr => Console.WriteLine(nameStr.ToUpper());


	Action<int, int> ComputeSum = (a, b) =>
	{
		var sum = a + b;
		Console.WriteLine(sum);
	};

	//last parameter is the return type
	Func<int, int, decimal> ComputeReturnSum = (a, b) =>
	{
		return (decimal)(a + b);
	};


	//use Func when there is a return value
	//Func is covariant in its return type and contravariant in its parameter types in C#.
	Func<string, string> printAndReturnNameInUpperCase = nameStr =>
	{
		var upper = nameStr.ToUpper();
		Console.WriteLine(upper);
		return upper;
	};

	public void Demo()
	{
		printNameInUpperCase("ashwin");
		var name = printAndReturnNameInUpperCase("ashwin");
	}
}
