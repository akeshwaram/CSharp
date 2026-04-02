using System.Runtime.InteropServices;
namespace InputOutput.Exercises;

//the extern keyword is used to declare a method that is implemented externally, meaning its body is defined outside of your C# code
internal class ExternExample
{
	[DllImport("kernel32.dll")]
	public static extern bool Beep(uint frequency, uint duration);

	public static void Demo()
	{
		Beep(1000, 2500);
		Console.WriteLine("");
	}
}
