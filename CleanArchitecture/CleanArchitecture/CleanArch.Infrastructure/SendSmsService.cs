using CleanArch.Contract;

namespace CleanArch.Infrastructure
{
    public class SendSmsService : ISmsService
    {
        public void SendSms(SendSmsDto body)
        {
            Console.WriteLine("sms is sent to num:{0} - with text {1}", body.Number, body.Text);
        }
    }
}
