
namespace InputOutput;

internal class Dictionaries
{
	private readonly static Dictionary<string, decimal> currencies = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase) {
		{ "USD", 1 }, {"INR", 90.58m }, {"EUR", 0.85m}
	};

	private static readonly Object _lock = new();
	private static int _id = 0;

	public static void CreateDictionary() {

		var cache = new ConcurrentDictionary<string, int>();
		cache.TryAdd("alice", 1);
		cache.TryRemove("alice", out _);
		cache.TryGetValue("Count", out int p);
		var exists = cache.TryGetValue("alice", out _);

		lock (_lock) {
			cache.GetOrAdd("bob", 4);
		}
		
		//cache.AddOrUpdate("alice", 7, (key, oldvalue) => oldvalue++);
		cache.AddOrUpdate("alice", key => 6, (key, _) => 7);
		cache.TryUpdate("alice", 9, 8);

		foreach (var kvp in cache) {
			Console.WriteLine($"key: {kvp.Key}  value:{kvp.Value}");
		}

		Interlocked.Increment(ref _id);
		TimeSpan _window = TimeSpan.FromHours(24);
	}

	public static decimal GetRate(string fromCurrency, string toCurrency) {
		currencies.Add("AEE", 2.3m);

		var fromRate = currencies[fromCurrency];
		var toRate = currencies[toCurrency];

		return toRate / fromRate;
	}
}
