namespace InputOutput;

internal class SimpleCache<TKey, TValue>
{
	Dictionary<TKey, TValue> _cache = new();

	public void Set(TKey key, TValue value)
	{
		_cache[key] = value;
	}

	public bool TryGet(TKey key, out TValue value)
	{
		
		return _cache.TryGetValue(key, out value);
	}

	public bool Remove(TKey key)
	{
		return _cache.Remove(key);
	}
}

internal class ExpiringCache<TKey, TValue> {
	Dictionary<TKey, CacheItem<TValue>> _cache = new();

	public void Set(TKey key, TValue value)
	{
		var item = new CacheItem<TValue>(value, new TimeSpan(1, 1, 1));
		_cache.Add(key, item);
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		value = default;

		if (!_cache.TryGetValue(key, out var item))
		{
			return false;
		}

		if (item.IsExpired)
		{
			_cache.Remove(key);
			return false;
		}

		value = item.Value;
		return true;
	}

	public void Remove(TKey key)
	{
		_cache.Remove(key);
	}
}

internal class CacheItem<TValue> {
	public TValue Value;
	public DateTime Expiry;
	
	public CacheItem(TValue value, TimeSpan tts)
	{
		Value = value;
		Expiry = DateTime.UtcNow.Add(tts);
	}

	public bool IsExpired => DateTime.Now > Expiry;
}
