

using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using RabbitMQ.Client;
using Utils;

//-------------------  جلسه اول تمرین 

//Console.WriteLine("hi dear user plz enter your phone number !");

//var phoneNum = Console.ReadLine();

//if (string.IsNullOrEmpty(phoneNum))
//{
//    Console.WriteLine("wrong format");
//    return;
//}

//Console.WriteLine("your entered phone number is {0}",phoneNum);

//var queueName = "sendOtpMessage";

//var connectionFactory = new ConnectionFactory()
//{
//    HostName = "localHost",
//    UserName = "guest",
//    Password = "guest"
//};

//var connection = await connectionFactory.CreateConnectionAsync();

//var model = await connection.CreateChannelAsync();

//await model.QueueDeclareAsync(queueName, true, false, false, null);

//var body = Encoding.UTF8.GetBytes(phoneNum);
//await model.BasicPublishAsync("", queueName, body);

//Console.WriteLine("done successful");
//Console.ReadLine();



//-------------------  جلسه دوم تمرین 



//Console.WriteLine("hi dear user plz enter your phone number !");

//var phoneNum = Console.ReadLine();

//if (string.IsNullOrEmpty(phoneNum))
//{
//    Console.WriteLine("wrong format");
//    return;
//}

//Console.WriteLine("your entered phone number is {0}", phoneNum);

//Console.WriteLine("plz enter your email address");

//var email = Console.ReadLine();



//var connectionFactory = new ConnectionFactory()
//{
//    HostName = "localHost",
//    UserName = "guest",
//    Password = "guest"
//};

//var connection = await connectionFactory.CreateConnectionAsync();

//var model = await connection.CreateChannelAsync();

//var queueName = "register_byFullInfoQueue";
//var exchangeName = "broadCastUser_register";

//await model.ExchangeDeclareAsync(exchangeName,ExchangeType.Fanout,true);

//var jsonBody = JsonSerializer.Serialize(new UserInfo()
//{
//    Email = email,
//    PhoneNumber = phoneNum
//});

//var byteBody = Encoding.UTF8.GetBytes(jsonBody);

//await model.BasicPublishAsync(exchangeName,queueName,byteBody);

//Console.WriteLine("notif sent");
//Console.ReadKey();










//-------------------  جلسه سوم تمرین 



//Console.WriteLine("hi dear user plz enter your phone number !");

//var phoneNum = Console.ReadLine();

//if (string.IsNullOrEmpty(phoneNum))
//{
//    Console.WriteLine("wrong format");
//    return;
//}

//Console.WriteLine("your entered phone number is {0}", phoneNum);

//Console.WriteLine("plz enter your email address");

//var email = Console.ReadLine();





//var connectionFactory = new ConnectionFactory()
//{
//    HostName = "localHost",
//    UserName = "guest",
//    Password = "guest"
//};

//var connection = await connectionFactory.CreateConnectionAsync();

//var model = await connection.CreateChannelAsync();

//var exchangeName = "User_Topic";

//await model.ExchangeDeclareAsync(exchangeName, ExchangeType.Topic, true);

//var jsonBody = JsonSerializer.Serialize(new UserInfo()
//{
//    Email = email,
//    PhoneNumber = phoneNum
//});

//do
//{


//    Console.WriteLine("plz enter your routing key");

//    var queueName = Console.ReadLine();
//    var byteBody = Encoding.UTF8.GetBytes(jsonBody);

//    await model.BasicPublishAsync(exchangeName, queueName, byteBody);

//    Console.WriteLine("notif sent");

//    Console.WriteLine("do you want send again?");

//    var answer = Console.ReadLine();

//    if(answer != "y")
//        break;


//} while (true);

//Console.WriteLine("press any key to done !");
//Console.ReadKey();





//-------------------  جلسه چهارم تمرین 


Console.WriteLine("hi dear user plz enter your phone number !");

var phoneNum = Console.ReadLine();

if (string.IsNullOrEmpty(phoneNum))
{
    Console.WriteLine("wrong format");
    return;
}

Console.WriteLine("your entered phone number is {0}", phoneNum);

Console.WriteLine("plz enter your email address");

var email = Console.ReadLine();





var connectionFactory = new ConnectionFactory()
{
    HostName = "localHost",
    UserName = "guest",
    Password = "guest"
};

var connection = await connectionFactory.CreateConnectionAsync();

var model = await connection.CreateChannelAsync();

var exchangeName = "User_Header";

await model.ExchangeDeclareAsync(exchangeName, ExchangeType.Headers, true);

var jsonBody = JsonSerializer.Serialize(new UserInfo()
{
    Email = email,
    PhoneNumber = phoneNum
});

do
{


    Console.WriteLine("plz enter your error level");

    var errorLevel = Console.ReadLine();

    var byteBody = Encoding.UTF8.GetBytes(jsonBody);

    var headers = new Dictionary<string, object>()
    {
        { "logLevel",errorLevel },
        { "applicationName", "Lms" }
    };

    BasicProperties basicProperties = new BasicProperties();
    basicProperties.Headers = headers;

    await model.BasicPublishAsync(exchangeName,"",false,basicProperties, byteBody);

    Console.WriteLine("notif sent");

    Console.WriteLine("do you want send again?");

    var answer = Console.ReadLine();

    if (answer != "y")
        break;


} while (true);

Console.WriteLine("press any key to done !");
Console.ReadKey();
