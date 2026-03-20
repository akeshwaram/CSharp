namespace InputOutput.OOPS;
//Abstraction hides implementation details and exposes only essential behavior
public class Abstraction { }
public abstract class Shape
{
	public abstract double GetArea();
}

public class Circle : Shape
{
	public double Radius { get; set; }

	public override double GetArea()
	{
		return 3.14 * Radius * Radius;
	}
}