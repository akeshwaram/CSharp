using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace InputOutput.C_4;

internal class NamedOptionalArguments
{
	public void Demo() {
		//method called in the normal way
		PrintOrderDetails("Amazon", 123, "Laptop");

		//using named arguments
		PrintOrderDetails(sellerName: "Amazon", orderNum: 123, productName: "Laptop");
		PrintOrderDetails(orderNum: 125, sellerName: "Google", productName: "Phone");

		//mix of named and positional arguments - valid as long as they are used in the correct order
		PrintOrderDetails(sellerName: "Google", 123, productName: "Phone");
		ExampleOptionalArguments("Amazon");
		ExampleOptionalArguments("Amazon", productName: "Tablet", orderNum: 145);
		ExampleOptionalArguments("Amazon", productName: "Tablet");
	}

	public void PrintOrderDetails(string sellerName, int orderNum, string productName)
	{ 
		
	}

	//[Optional] is another way to specify that an argument is optional, but it doesn't allow you to specify a default value.
	//If you want to specify a default value, you can use the [DefaultParameterValue] attribute.
	public void ExampleOptionalArguments(string sellerName, [Optional, DefaultParameterValue("Microsoft")] string productName, int orderNum = 0)
	{
		Console.WriteLine($"Seller: {sellerName}, Order Number: {orderNum}, Product Name: {productName}");
	}
}
