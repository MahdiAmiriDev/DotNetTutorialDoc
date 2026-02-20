using EventMessages.Events;
using MassTransit;

namespace NotificationService.Features.Sms
{



    public class GetEvent: IConsumer<OtpEvent>
    {
        public Task Consume(ConsumeContext<OtpEvent> context)
        {
            Console.WriteLine("RabbitMq MobileNumber:{0}",context.Message.MobileNumber);
            Console.WriteLine("\n");
            Console.WriteLine("RabbitMq OtpCode:{0}", context.Message.OtpCode);
            Console.WriteLine("\n");
            Console.WriteLine("Done!");
            return Task.CompletedTask;
        }
    }

}
