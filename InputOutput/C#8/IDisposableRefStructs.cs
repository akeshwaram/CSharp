using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_8;

internal class IDisposableRefStructs
{
	public void Demo() {
		using var rect = new Rectangle(5, 10); //able to use using because Rectangle implements IDisposable
		var area = rect.Area();
		Console.WriteLine($"Area of rectangle is {area}");
	}
}

//ref structs can only live on the stack, they cannot be boxed
//regular structs can live anywhere depending on where they are used
//in C#8 ref struct cannot implment interfaces, but as long as it has a Dispose method, it can be used with the using statement
//starting C#13 ref structs can implement interfaces
ref struct Rectangle : IEmpty { 
	private double Height { get; set; }
	private double Width { get; set; }

	public Rectangle(int width, int height) {
		Height = height;
		Width = width;
	}

	public double Area() => Height * Width;

	public void Dispose()
	{
		Console.WriteLine("Rectangle object disposed of");
	}
}

public interface IEmpty { }