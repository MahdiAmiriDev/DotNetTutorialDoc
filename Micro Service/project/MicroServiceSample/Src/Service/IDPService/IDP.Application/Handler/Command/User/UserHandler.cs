﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDP.Application.Command.User;
using MediatR;

namespace IDP.Application.Handler.Command.User
{
    public class UserHandler : IRequestHandler<UserCommand, bool>
    {

        public UserHandler()
        {
        }

        public async Task<bool> Handle(UserCommand request, CancellationToken cancellationToken)
        {
            //await _userRepository.InsertAsync(new Domain.Entities.User()
            //{
            //    FullName = request.FullName,
            //    NationalCode = request.NationalCode 
            //});

            return true;
        }
    }
}
