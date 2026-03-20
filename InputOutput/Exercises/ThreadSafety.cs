namespace InputOutput.Exercises;

public class Increment
{
	public int Count { get; set; }
	private readonly object _lock = new();
	public void IncrementCounter(ref int a)
	{
		for (int i = 0; i < 10; i++)
		{
			Interlocked.Increment(ref a);
		}
	}
}

internal class ThreadSafety
{
	public static void AchieveRaceCondition()
	{
		var a = 0;
		var inc = new Increment();
		Thread t1 = new Thread(() => inc.IncrementCounter(ref a));
		Thread t2 = new Thread(() => inc.IncrementCounter(ref a));

		t1.Start();
		t2.Start();
		t1.Join();
		t2.Join();


		Console.WriteLine($"Final value of count is {a}");

	}
}
