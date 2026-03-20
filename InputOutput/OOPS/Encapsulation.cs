namespace InputOutput.OOPS;

//Encapsulation means hiding internal data and controlling access through methods or properties.
internal class Account
{
	private decimal balance;

	public decimal GetBalance() => balance;

	public void Deposit(decimal amount)
	{
		balance += amount;
	}
}

public class Encapsulation
{
	public void Actions()
	{
		Account a = new();
		a.Deposit(100);
		Console.WriteLine(a.GetBalance());
	}
}

