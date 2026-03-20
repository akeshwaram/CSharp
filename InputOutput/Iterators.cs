namespace InputOutput;

internal class Iterators
{
	public static IEnumerable<int> ReturnEvenNumbers(int limit)
	{
		yield return 2;
		yield return 3;

		for (int i= 3; i <= limit; i++)
		{
			if (i % 2 == 0)
				yield return i;
		}
	}
}
