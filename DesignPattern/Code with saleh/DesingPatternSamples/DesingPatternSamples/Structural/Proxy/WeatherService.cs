using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Proxy
{
    internal class WeatherService : Subject
    {
        private readonly string apiUrl;
        private readonly string apiKey;

        public WeatherService(string apiUrl, string apiKey)
        {
            this.apiUrl = apiUrl;
            this.apiKey = apiKey;
        }

        public void Request()
        {
            Console.WriteLine("send request to {0} wiht key {1}", apiUrl, apiKey);
        }
    }
}
