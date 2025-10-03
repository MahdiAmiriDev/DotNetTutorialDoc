using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDP.Domain.Entities;
using IDP.Domain.IRepository.Command;

namespace IDP.Infra.Repository.Command
{
    public class UserRepository: IUserRepository
    {
        public Task<bool> InsertAsync(User user)
        {
            return Task.FromResult(true);
        }
    }
}
