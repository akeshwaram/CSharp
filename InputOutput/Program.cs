using InputOutput.C_3;
using InputOutput.C_4;
using InputOutput.C_5;
using InputOutput.C_6;
using InputOutput.Exercises.Partial_Classes;
using InputOutput.OOPS;

internal class Program
{
	private async static Task<int> Main(string[] args)
	{
		//NameOf.Demo();
		//NullPropogation.Demo();
		//StringInterpolation.Demo();
		var task = await ExceptionFilters.Demo();

		var aType = new AnonymousTypes();
		aType.Demo();

		var dyn = new DynamicType();
		dyn.Demo();

		var s = CallerInfoAttributes.DoSomething("This method prints caller info");

		new CallerInfoAttributes().DoSomethingElse();
		//ThreadSafety.AchieveRaceCondition();
		//Deadlock.SimulateDeadlock();

		//Inheritance i = new();
		//i.DoSomething();

		char[] chars = { 'h', 'e', 'l', 'l', 'o' };
		Console.WriteLine(chars);
		var a = new A();
		a.Print();
		a.Email();

		Polymorphism p = new();
		p.DoSomething();
		//Thread t = Thread.CurrentThread;
		//t.Name = "Main Thread";
		//Console.WriteLine($"main thread name is {t.Name}");
		////Tasks.CreateProcess();
		////Tasks.CreateThreads();
		//Tuples.PrintTuple();

		//var secondLargest = MyStack.ReturnSecondLargestElement([1, 5, 6, 2, 8, 9, 6]);
		//Console.WriteLine($"second largest: {secondLargest}");

		//var setbits = BitOperations.CountSetBits(23);

		//var list = new List<int>() { 1, 2};
		//var newlist = Generics.CopyAtMost(list, 1);
		//Dictionaries.CreateDictionary();
		//var rate = Dictionaries.GetRate("EUR", "INR");

		//var source = new List<int>() { 1, 2, 3, 4, 5, 6 };
		//var acc = FunctionsUsingLoops.Reduce(source, 0, (x, y) => x + y);
		//var result = FunctionsUsingLoops.Take(source, 5);

		//StringBuilder sb = new StringBuilder();

		//var n = DynamicProgramming.FibMemo(6);

		//var decimals = new List<decimal> { 1, 2 };
		//Generics.RefineList(decimals);
		//Generics.RefineList<Decimal>(decimals);
		//Generics.RefineList<Decimal, Decimal>(decimals);

		//var b = new Box<List<decimal>>();

		//var evenNumbers = Iterators.ReturnEvenNumbers(11);
		//var iterator = evenNumbers.GetEnumerator();

		//while (iterator.MoveNext()) { 

		//}

		//int[] arr = new []{ 1, 2};
		//int a = arr.Count();
		//Console.WriteLine(5.ToString());


		//Action<string> action = s => { Console.WriteLine(s); };

		//Func<string, int> multiply = x =>  x.Length * x.Length; ;

		//action("");

		//Task<int> lengthTask = Tasks.GetPageLengthAsync("sample URL");
		//return lengthTask.Result;
		return 1;
		//Console.WriteLine(lengthTask.Result);

	}
}