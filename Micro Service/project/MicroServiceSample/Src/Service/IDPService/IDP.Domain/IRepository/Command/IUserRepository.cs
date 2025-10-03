using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDP.Domain.Entities;

namespace IDP.Domain.IRepository.Command
{
    public interface IUserRepository
    {
        /// <summary>
        ///  درج کاربر
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<bool> InsertAsync(User  user);
    }
}
