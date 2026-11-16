using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InputOutput.C_6;

internal class ExceptionFilters
{
	public static async Task<string> Demo()
	{
		var client = new HttpClient();
		var streamTask = client.GetStringAsync("https://www2.ashwinkeshwaram.com/");

		try
		{
			var responseText = await streamTask;
			return responseText;
		}
		catch (Exception e) when (e.Message.Contains("301"))
		{
			return "Site moved permanently";
		}
		catch (Exception e) when (e.Message.Contains("No such host is known"))
		{
			return "Site not found";
		}
		catch (Exception e){ 
			return "Some other error occurred";
		}
	}

	//when can also be used in switch statements
	public static void SwitchWhenDemo() {
		int number = 10;
		switch (number)
		{
			case int n when n > 0:
				Console.WriteLine("Positive number");
				break;

			case int n when n < 0:
				Console.WriteLine("Negative number");
				break;
			case(0):
				Console.WriteLine("Zero");
				break;

			default:
				Console.WriteLine("Zero");
				break;
		}
	}
}
