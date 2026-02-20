
using System.Security.Cryptography;
using DotNetCore.CAP;
using EventMessages.Events;
using IDP.Application.Command.Auth;
using IDP.Domain.DTO;
using MediatR;
using IDP.Domain.IRepository.Command;
using MassTransit;

namespace IDP.Application.Handler.Command.Auth
{
    public class AuthCommandHandler : IRequestHandler<AuthCommand, bool>
    {
        private readonly IOptRedisRepository _optRedisRepository;
        private readonly ICapPublisher _capPublisher;
        private readonly IPublishEndpoint _publishEndpoint;


        public AuthCommandHandler(IOptRedisRepository optRedisRepository, ICapPublisher capPublisher, IPublishEndpoint publishEndpoint)
        {
            _optRedisRepository = optRedisRepository;
            _capPublisher = capPublisher;
            _publishEndpoint = publishEndpoint;
        }

        public async Task<bool> Handle(AuthCommand request, CancellationToken cancellationToken)
        {

            //await _capPublisher.PublishAsync<AuthCommand>("otpEvent", new AuthCommand()
            //{
            //    MobileNumber = "09337132998"
            //}, cancellationToken: cancellationToken);  

            var random = new Random();
            var randomNum = random.Next(1000, 2000);

            await _publishEndpoint.Publish<OtpEvent>(new OtpEvent()
            {
                MobileNumber = request.MobileNumber,
                OtpCode = randomNum.ToString(),
            }, cancellationToken);

            //SaveChangeAsync()

            //await _optRedisRepository.Insert(new Opt()
            //{
            //    IsUse = false,
            //    OptCode = 3254.ToString(),
            //    UserId = int.Parse(request.MobileNumber)
            //});

            return true;
        }
    }
}
