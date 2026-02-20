
using System.Text;
using System.Text.Json;
using RabbitMQ.Client;
using Utils;

Console.WriteLine("this is order application !");
Console.WriteLine("plz enter your phone number");
var phoneNumber = Console.ReadLine();
Console.WriteLine("plz enter your email address");
var emailAddress = Console.ReadLine();

OrderDto orderDto = new()
{
    MobileNumber = phoneNumber,
    PhoneNumber = emailAddress,
    CourseNameList = new List<string>()
    {
        ".net","rabbitMq","docker"
    }
};

var connectionFactory = new ConnectionFactory()
{
    HostName = "localHost",
    UserName = "guest",
    Password = "guest"
};

var connection = await connectionFactory.CreateConnectionAsync();

var channel = await connection.CreateChannelAsync();

var exchangeName = "CalcOrderFeeExchange";

var queueName = "CalcOrderFeeHandler";

await channel.ExchangeDeclareAsync(exchangeName,ExchangeType.Direct,true,false);

await channel.QueueDeclareAsync(queueName,true,false,false);

await channel.QueueBindAsync(queueName,exchangeName,queueName);

await channel.BasicPublishAsync(exchangeName,queueName,false,
    Encoding.UTF8.GetBytes(JsonSerializer.Serialize(orderDto)));


Console.ReadKey();

