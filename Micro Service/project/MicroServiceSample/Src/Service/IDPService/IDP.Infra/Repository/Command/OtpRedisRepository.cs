using IDP.Domain.IRepository.Command;
using System.Text.Json;
using IDP.Domain.DTO;
using Microsoft.Extensions.Caching.Distributed;

namespace IDP.Infra.Repository.Command
{
    public class OtpRedisRepository : IOptRedisRepository
    {
        private readonly IDistributedCache _distributedCache;
        public OtpRedisRepository(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public Task<Opt> Insert(Opt entity)
        {
            _distributedCache.SetString(entity.UserId.ToString(), JsonSerializer.Serialize(entity),
                new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(2))
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(2)));

            return Task.FromResult(entity);
        }

        public Task<bool> Delete(Opt entity)
        {
            _distributedCache.Remove(entity.UserId.ToString());
            return Task.FromResult(true);
        }

        public Task<bool> Update(Opt entity)
        {
            throw new NotImplementedException();
        }
    }
}
