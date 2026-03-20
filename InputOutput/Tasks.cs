using System.Diagnostics;

namespace InputOutput;

internal class Tasks
{

	static readonly HttpClient client = new HttpClient();

	public static async Task<int> GetPageLengthAsync(string url)
	{ 
		Task<string> fetchLengthTask = client.GetStringAsync(url);
		//var s = fetchLengthTask.Result; //Use await wherever you can. use Result when you must absolutely block until the operation is done. 
		var str = await fetchLengthTask;

		return str.Length;
	}

	public static void CreateProcess() {
		Process p = new();
		p.StartInfo.FileName = "notepad.exe";
		p.Start();
		p.WaitForExit();
		Console.WriteLine("Notepad is now closed");
	}

	public static void CreateThreads()
	{
		Thread thread1 = new Thread(()=>CountDown("timer 1"));
		Thread thread2 = new Thread(()=>CountUp("timer 2"));
		thread1.Start();
		thread2.Start();
	}

	public static void CountDown(string tname)
	{
		for (int i = 10; i >= 0; i--) {
			Console.WriteLine($"Timer 1: {i}");
			Thread.Sleep(500);
		}
	}

	public static void CountUp(string tname)
	{
		for (int i = 0; i <= 10; i++)
		{
			Console.WriteLine($"Timer 2: {i}");
			Thread.Sleep(500);
		}
	}
}
