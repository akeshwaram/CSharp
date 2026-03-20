namespace InputOutput;

internal class DynamicProgramming
{
	static Dictionary<int, int> memo = new();
	public static int FibMemo(int n)
	{
		if (n <= 1)
			return n;

		if (memo.ContainsKey(n))
		{
			return memo[n];
		}

		memo[n] = FibMemo(n - 1) + FibMemo(n - 2);
		return memo[n];
	}
}
