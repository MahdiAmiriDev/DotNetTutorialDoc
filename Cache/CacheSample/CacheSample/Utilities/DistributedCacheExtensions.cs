using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CacheSample.Utilities
{
    public static class DistributedCacheExtensions
    {
        public static async Task<T?> GetOrSetAsync<T>(this IDistributedCache cache, string key, Func<Task<T>> func, DistributedCacheEntryOptions option)
        {
            var value = await cache.GetAsync(key);

            if (value == null || !value.Any())
            {
                var valueToBeCache = await func();

                if (valueToBeCache == null)
                    return default(T);

                await SetAsync(cache,valueToBeCache,key,option);

                return valueToBeCache;
            }

            return JsonSerializer.Deserialize<T>(value);
        }

        private static async Task SetAsync<T>(this IDistributedCache cache,T value ,string key, DistributedCacheEntryOptions option)
        {            
            var bytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(value));

            await cache.SetAsync(key, bytes, option);
        }
    }
}
