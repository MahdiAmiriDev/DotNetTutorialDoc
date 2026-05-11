using CacheSample.Classes;
using CacheSample.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;

namespace CacheSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        //private readonly IMemoryCache _memoryCache;
        private readonly IDistributedCache _distributedCache;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDistributedCache distributedCache)
        {
            _logger = logger;
            //_memoryCache = memoryCache;
            _distributedCache = distributedCache;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        #region memory cache
        [HttpGet("TestMemoryCache")]
        public async Task<IActionResult> TestMemoryCacheAsync()
        {

            //var res = await _memoryCache.GetOrCreateAsync("test", factory =>
            //{
            //    Thread.Sleep(10000);

            //    //بعد 10 ثانیه کش را خودکار پاک کن
            //    factory.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(10);

            //    return Task.FromResult(new
            //    {
            //        IsSuccess = true,
            //        Message = "done !"
            //    });

            //});


            //return Ok(res);

            return default;
        }

        [HttpGet("RemoveMemoryCache")]
        public IActionResult RemoveMemoryCache()
        {

            //_memoryCache.Remove("test");

            //return Ok(new { IsSuccess = true, Message = "done !" });

            return default;
        }

        #endregion



        #region distributed cache


        [HttpGet("DistributedCacheTest")]
        public async Task<IActionResult> DistributedCacheTestAsync()
        {
            var res = await _distributedCache.GetOrSetAsync(CacheKey.TestOne, () =>
            {
                Thread.Sleep(8000);

                return Task.FromResult(new
                {
                    IsSuccess = true,
                    Message = "distributed cache work correctly !"
                });
            },
                new DistributedCacheEntryOptions
                {
                    AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(60)
                }
            );

            return Ok(res);
        }




        #endregion
    }
}
