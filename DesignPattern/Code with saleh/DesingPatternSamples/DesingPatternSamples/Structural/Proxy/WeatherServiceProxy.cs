using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Proxy
{
    internal class WeatherServiceProxy : Subject
    {
        private readonly string apiUrl;
        private readonly string apiKey;
        private readonly WeatherService weatherService;
        private readonly Dictionary<string,bool> cache = new();

        public WeatherServiceProxy(string apiUrl, string apiKey)
        {
            this.apiUrl = apiUrl;
            this.apiKey = apiKey;
            weatherService = new WeatherService(apiUrl,apiKey);
        }

        public void Request()
        {
            var cacheKey = GetCacheKey();

            if (cache.TryGetValue(cacheKey, out var value))
            {
                Console.WriteLine("read from cache...");
            }

            cache.Add(cacheKey, true);

            weatherService.Request();

        }

        private string GetCacheKey()
        {
            return DateTime.Now.ToString("HH:mm");
        }
    }
}
