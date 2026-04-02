using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.Exercises;

internal class RuntimePolymorphism
{
	public static void Demo() {
		Animal a = new Dog();
		a.Speak(); //dog speak
		a.Run(); //animal run 

		Animal c = new Cat();
		c.Speak(); //cat speak
	}

}

public class Animal {
	public virtual void Speak() {
		Console.WriteLine("Animal speaks");
	}

	public void Run() {
		Console.WriteLine("Animal runs");
	}
}

public class Dog : Animal {
	public override void Speak() {
		Console.WriteLine("Dog speaks");
	}

	//this is not runtime polymorphism. this is method hiding (compile-time behavior)
	//method is determined by reference type, not the actual object type
	public new void Run() {
		Console.WriteLine("Dog runs");
	}
}

public class Cat : Animal
{
	public override void Speak()
	{
		Console.WriteLine("Cat speaks");
	}
}
