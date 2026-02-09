using Microsoft.Extensions.Caching.Distributed;


namespace CacheExample
{
    public class KeyPrefixedCache : IDistributedCache
    {
        private IDistributedCache _cache;
        private string _prefix;

        public KeyPrefixedCache(IDistributedCache cache, string prefix)
        {
            _cache = cache;
            _prefix = prefix;
        }

        public string PrefixKey(string key) =>
            $"{_prefix}_{key}";

        public byte[]? Get(string key) =>
            _cache.Get(PrefixKey(key));

        public Task<byte[]?> GetAsync(string key, CancellationToken token = default) =>
            _cache.GetAsync(PrefixKey(key), token);

        public void Refresh(string key) =>
            _cache.Refresh(PrefixKey(key));

        public Task RefreshAsync(string key, CancellationToken token = default) =>
            _cache.RefreshAsync(PrefixKey(key), token);
    }
}
