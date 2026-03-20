namespace InputOutput;

internal class FunctionsUsingLoops
{
	public static IEnumerable<TResult> Map<TSource, TResult>(
		IEnumerable<TSource> source,
		Func<TSource,TResult> selector
		) {

		var result = new List<TResult>();
		foreach (var item in source) { 
			result.Add(selector(item));
		}

		return result;
	}

	public static TResult Reduce<TSource, TResult>(IEnumerable<TSource> source,
		TResult seed,
		Func<TResult, TSource, TResult> selector)
	{
		var result = seed;

		foreach (var item in source)
		{
			result = selector(result, item);
		}

		return result;
	}


	public static IEnumerable<TSource> Take<TSource>(
		IEnumerable<TSource> source,
		int count
		)
	{
		var result = new List<TSource>();
		var taken = 0;

		foreach(var item in source) {
			if (taken == count)
			{
				return result;
			}

			result.Add(item);
			taken++;
		}

		return result;

	}













}
