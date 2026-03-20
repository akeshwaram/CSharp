namespace InputOutput.Exercises;
internal class Deadlock
{
	private readonly object _lock1 = new object();
	private readonly object _lock2 = new object();

	private void Job1()
	{
		bool lock1taken = false;
		bool lock2taken = false;

		Monitor.TryEnter(_lock1, 1000, ref lock1taken);

		if (lock1taken)
		{
			Thread.Sleep(1000);

			Monitor.TryEnter(_lock2, 1000, ref lock2taken);

			if (lock2taken)
			{
				Console.WriteLine("Job1 is complete");
			}
			else
			{
				Console.WriteLine("Couldn't acqiure lock2");
			}
		}
	}

	private void Job2()
	{
		bool lock1taken = false;
		bool lock2taken = false;

		Monitor.TryEnter(_lock2, 1000, ref lock2taken);

		if (lock2taken)
		{
			Thread.Sleep(1000);

			Monitor.TryEnter(_lock1, 1000, ref lock1taken);

			if (lock1taken)
			{
				Console.WriteLine("Job2 is complete");
			}
			else
			{
				Console.WriteLine("Couldn't acqiure lock1");
			}
		}
	}

	public static void SimulateDeadlock()
	{
		var d = new Deadlock();
		Thread t1 = new Thread(d.Job1);
		Thread t2 = new Thread(d.Job2);

		t1.Start();
		t2.Start();

		t1.Join();
		t2.Join();

		Console.WriteLine("End of program");
	}
}
