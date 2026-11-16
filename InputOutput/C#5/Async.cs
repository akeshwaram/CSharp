using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_5;

internal class HashBrown { }
internal class Coffee { }
internal class Egg { }
internal class Juice { }
internal class Toast { }

internal class Async
{
	internal static async Task MakeBreakfastAsync()
	{
		Coffee cup = PourCoffee();
		Console.WriteLine("coffee is ready");

		var eggsTask = FryEggsAsync(2);
		var hashBrownTask = FryHashBrownsAsync(3);
		var toastTask = MakeToastWithButterAndJamAsync(2);

		List<Task> breakfastTasks = [ eggsTask, hashBrownTask, toastTask ];

		//you can start the FryHashBrownsAsync task. You can choose when to wait on the task by using await. Meanwhile, the task is running and you can do other work.
		var hashBrownTask2 = FryHashBrownsAsync(3);
		var hashBrown = await hashBrownTask2;
		Console.WriteLine("hash browns are ready");

		//a better approach is to use WhenAll or WhenAny
		while (breakfastTasks.Count > 0)
		{
			Task finishedTask = await Task.WhenAny(breakfastTasks);
			if (finishedTask == eggsTask)
			{
				Console.WriteLine("eggs are ready");
			}
			else if (finishedTask == hashBrownTask)
			{
				Console.WriteLine("hash browns are ready");
			}
			else if (finishedTask == toastTask)
			{
				Console.WriteLine("toast is ready");
			}
			await finishedTask;
			breakfastTasks.Remove(finishedTask);
		}

		Juice oj = PourOJ();
		Console.WriteLine("oj is ready");
		Console.WriteLine("Breakfast is ready!");
	}

	private static async Task<Egg> FryEggsAsync(int howMany)
	{
		Console.WriteLine("Warming the egg pan...");
		await Task.Delay(3000);
		Console.WriteLine($"cracking {howMany} eggs");
		Console.WriteLine("cooking the eggs ...");
		await Task.Delay(3000);
		Console.WriteLine("Put eggs on plate");

		return new Egg();
	}

	private static async Task<HashBrown> FryHashBrownsAsync(int patties)
	{
		Console.WriteLine($"putting {patties} hash brown patties in the pan");
		Console.WriteLine("cooking first side of hash browns...");
		await Task.Delay(3000);
		for (int patty = 0; patty < patties; patty++)
		{
			Console.WriteLine("flipping a hash brown patty");
		}
		Console.WriteLine("cooking the second side of hash browns...");
		await Task.Delay(3000);
		Console.WriteLine("Put hash browns on plate");

		return new HashBrown();
	}

	//combination of async and sync methods is still async
	static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
	{
		var toast = await ToastBreadAsync(number);
		ApplyButter(toast);
		ApplyJam(toast);

		return toast;
	}

	private static void ApplyJam(Toast toast) =>
			Console.WriteLine("Putting jam on the toast");

	private static void ApplyButter(Toast toast) =>
		Console.WriteLine("Putting butter on the toast");

	private static async Task<Toast> ToastBreadAsync(int slices)
	{
		for (int slice = 0; slice < slices; slice++)
		{
			Console.WriteLine("Putting a slice of bread in the toaster");
		}
		Console.WriteLine("Start toasting...");
		await Task.Delay(3000);
		Console.WriteLine("Remove toast from toaster");

		return new Toast();
	}

	private static Juice PourOJ()
	{
		Console.WriteLine("Pouring orange juice");
		return new Juice();
	}

	private static Coffee PourCoffee()
	{
		Console.WriteLine("Pouring coffee");
		return new Coffee();
	}
}
