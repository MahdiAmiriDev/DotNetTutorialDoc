namespace CleanArch.Contract;

public interface ISmsService
{

    void SendSms(SendSmsDto body);
}

public class SendSmsDto
{
    public int Number { get; set; }

    public string Text { get; set; }

}