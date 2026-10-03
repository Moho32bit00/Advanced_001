using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_001_Assignment
{
    public class Cache<TKey, TValue> where TKey : notnull
    {
        public int Count => _storage.Count;

        private class CacheItem
        {
            public TValue Value { get; }
            public DateTime ExpirationTime { get; }

            public CacheItem(TValue value, TimeSpan ttl)
            {
                Value = value;
                ExpirationTime = DateTime.UtcNow.Add(ttl);
            }

            public bool IsExpired => DateTime.UtcNow >= ExpirationTime;
        }

        private readonly Dictionary<TKey, CacheItem> _storage = new Dictionary<TKey, CacheItem>();

        public void Add(TKey key, TValue value, TimeSpan ttl)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            _storage[key] = new CacheItem(value, ttl);
        }

        public bool TryGet(TKey key, out TValue? value)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            if (_storage.TryGetValue(key, out var item))
            {
                if (!item.IsExpired)
                {
                    value = item.Value;
                    return true;
                }

                _storage.Remove(key);
            }

            value = default;
            return false;
        }

        public bool Contains(TKey key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            if (_storage.TryGetValue(key, out var item))
            {
                if (!item.IsExpired)
                {
                    return true;
                }
                _storage.Remove(key);
            }

            return false;
        }

        public bool Remove(TKey key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));

            return _storage.Remove(key);
        }
         
        public void RemoveExpired()
        {
            var keysToRemove = new List<TKey>();

            foreach (var kvp in _storage)
            {
                if (kvp.Value.IsExpired)
                {
                    keysToRemove.Add(kvp.Key);
                }
            }

            foreach (var key in keysToRemove)
            {
                _storage.Remove(key);
            }
        }
    }
}
