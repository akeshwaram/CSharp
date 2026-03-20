namespace InputOutput.Exercises;

internal class MyStack
{
	public static int ReturnSecondLargestElement(List<int> elements)
	{
		var stack = new Stack<int>();

		foreach (var element in elements)
		{
			stack.Push(element);
		}

		return stack.OrderByDescending(x => x).Skip(1).First();
	}

	public MyStack() : base()
	{
	}
}
