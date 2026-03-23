using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace InputOutput.C_7;

public enum CustomerType { Regular, Premium, VIP }

public record Order(int Items, decimal Cost);

//Pattern matching is a technique where you test an expression to determine if it has certain characteristics
internal class PatternMatching
{
	public CustomerType CustType { get; set; }

	public void Demo() {

		//Use pattern matching to check if an object is of a certain type and extract its value
		int? maybe = 12;
		if (maybe is int number)
		{
			Console.WriteLine($"maybe has value{number}");
		}
		else {
			Console.WriteLine("maybe is null");
		}

		//you don't have to assign the value to a new variable
		string? message = "some random message";
		if (message is not null)
		{
			Console.WriteLine($"message is {message}");
		}
	}

	public int SwitchExpressionDemo(CustomerType custType) =>
		//switch expression must return a value
		custType switch
		{
			CustomerType.Premium => 1,
			CustomerType.Regular => 2,
			CustomerType.VIP => 3,
			_ => 4,
		};

	public string WaterState(int tempInFarenheit) =>
		tempInFarenheit switch
		{
			< 32 => "solid",
			32 => "solid/liquid transition",
			> 32 and < 212 => "liquid",
			212 => "liquid/gas transition",
			> 212 => "gas",
		};

	public static int GetDiscount(Order order) =>
		order switch
		{
			{ Items: > 10, Cost: > 1000 } => 10,
			{ Items: > 5, Cost: > 500 } => 5,
			null => throw new ArgumentNullException(nameof(order), "order is missing"),
			_ => 0

		};
}

