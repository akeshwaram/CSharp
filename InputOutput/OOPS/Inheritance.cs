namespace InputOutput.OOPS;

public class Animal
{
	public void Eat()
	{
		Console.WriteLine("Animal is eating");
	}
}

public class Dog : Animal
{
	public void Bark()
	{
		Console.WriteLine("Dog is barking");
	}
}

internal class Inheritance
{
	public void DoSomething()
	{
		Animal a = new Animal();
		a.Eat();

		Dog d = new Dog();
		d.Bark();
	}
}