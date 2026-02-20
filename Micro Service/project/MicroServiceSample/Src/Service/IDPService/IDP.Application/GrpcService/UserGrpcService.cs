using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using UserService.Grpc;

namespace IDP.Application.GrpcService
{
    public class UserGrpcService:UserGrpc.UserGrpcBase
    {
        public override Task<GetUserByIdResponse> GetUserById(GetUserByIdRequest request, ServerCallContext context)
        {
            return Task.FromResult(new GetUserByIdResponse()
            {
                Email = "mahdiamirigamefa@gmail.com",
                Id = 1,
                Name = "Mahdi Amiri"
            });
        }
    }
}
