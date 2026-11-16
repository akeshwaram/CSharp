namespace InputOutput.C_2;
internal class Enumerators
{
	public void TestEnumerators()
	{

		//iterators support indexing - so you can use foreach/for with them
		var list = new ListClass<string>();

		foreach (var i in list)
		{
			//do something
		}

		foreach (var i in list.SampleIterator(1, 10))
		{
			//do something
		}

		foreach (var i in list)
		{
			//do something
		}

		//can't use for loop with enumerators - they don't support indexing
		var normalEnumerator = list.GetEnumerator();
		while (normalEnumerator.MoveNext())
		{
			Console.WriteLine(normalEnumerator.Current);
		}

		var explicityEnumerator = ((IEnumerable)list).GetEnumerator();
		while (explicityEnumerator.MoveNext())
			Console.WriteLine(explicityEnumerator.Current);
	}

}
//be wary of return types - ienumerable vs ienumerator
public class ListClass<T> : IEnumerable<T>
{
	//public modifier is illegal with this method here because we are explicitly implementing the method from the interface IEnumerable
	//explicit implementation is needed here because without it we would have two methods with the same name/signature leading to ambiguity
	IEnumerator IEnumerable.GetEnumerator()
	{
		for (int i = 0; i < this.Count(); i++)
		{
			yield return this.ElementAt(i);
		}
	}

	public IEnumerator<T> GetEnumerator()
	{
		for (int i = 0; i < this.Count(); i++)
		{
			yield return this.ElementAt(i);
		}
	}

	public IEnumerable<T> SampleIterator(int start, int end)
	{
		for (int i = start; i <= end; i++)
		{
			yield return this.ElementAt(i);
		}
	}
}
