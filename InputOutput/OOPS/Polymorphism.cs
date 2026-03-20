namespace InputOutput.OOPS;

public class Animal2
{
	public virtual void Speak()
	{
		Console.WriteLine("Animal speaks");
	}

	public void Speak(string sound)
	{
		Console.WriteLine($"Animal {sound}");
	}

	public void Run()
	{
		Console.WriteLine("Animal runs");
	}
}

public class Dog2 : Animal2
{

	public override void Speak()
	{
		Console.WriteLine("Dog barks");
	}

	public void Run()
	{
		Console.WriteLine("Dog runs");
	}
}

public class Cat2 : Animal2
{

	public override void Speak()
	{
		Console.WriteLine("Cat meows");
	}
}

internal class Polymorphism
{
	public void DoSomething()
	{
		Animal2 a = new Animal2();
		a.Speak();
		a.Speak("blah");

		Animal2 d = new Dog2();
		d.Speak();

		Animal2 c = new Cat2();
		c.Speak();

		//method hiding example - resolved using the reference type, not the object type

		Dog2 d3 = new Dog2();
		d3.Run(); //dog runs
		Animal2 d2 = new Dog2();
		d2.Run(); //animal runs
	}
}
