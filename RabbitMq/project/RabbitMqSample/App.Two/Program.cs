using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Utils;


//-------------------  جلسه اول تمرین 


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

//var consumer = new AsyncEventingBasicConsumer(model);

//consumer.ReceivedAsync += async (sender, args) =>
//{
//    var result = Encoding.UTF8.GetString(args.Body.ToArray());
//    Console.WriteLine("message send for {0}", result);
//    await model.BasicAckAsync(args.DeliveryTag, multiple: false);
//};


//await model.BasicConsumeAsync(queueName, false, consumer);
//Console.ReadKey();





//-------------------  جلسه دوم تمرین 



//var connectionFactory = new ConnectionFactory()
//{
//    HostName = "localHost",
//    UserName = "guest",
//    Password = "guest"
//};

//var connection = await connectionFactory.CreateConnectionAsync();

//var model = await connection.CreateChannelAsync();

//var queueName = "notifBy_phoneNum";
//var exchangeName = "broadCastUser_register";

//await model.QueueDeclareAsync(queueName, true, false, false, null);
//await model.ExchangeDeclareAsync(exchangeName, ExchangeType.Fanout, true);

//await model.QueueBindAsync(queueName, exchangeName, "");

//var consumer = new AsyncEventingBasicConsumer(model);

//consumer.ReceivedAsync += async (sender, args) =>
//{
//    var resultString = Encoding.UTF8.GetString(args.Body.ToArray());
//    var userInfo = JsonSerializer.Deserialize<UserInfo>(resultString);

//    Console.WriteLine("notif sent to mobileNum: {0}", userInfo.PhoneNumber);
//    await model.BasicAckAsync(args.DeliveryTag, false);
//    await Task.CompletedTask;
//};

//await model.BasicConsumeAsync(queueName, false, consumer);

//Console.ReadKey();









//-------------------  جلسه سوم تمرین 



//var connectionFactory = new ConnectionFactory()
//{
//    HostName = "localHost",
//    UserName = "guest",
//    Password = "guest"
//};

//var connection = await connectionFactory.CreateConnectionAsync();

//var model = await connection.CreateChannelAsync();

//var queueName = "notifBy_phoneNum";
//var exchangeName = "User_Topic";

//await model.QueueDeclareAsync(queueName, true, false, false, null);
//await model.ExchangeDeclareAsync(exchangeName, ExchangeType.Topic, true);

//await model.QueueBindAsync(queueName, exchangeName, "sms.*");

//var consumer = new AsyncEventingBasicConsumer(model);

//consumer.ReceivedAsync += async (sender, args) =>
//{
//    var resultString = Encoding.UTF8.GetString(args.Body.ToArray());
//    var userInfo = JsonSerializer.Deserialize<UserInfo>(resultString);

//    Console.WriteLine("notif sent to mobileNum: {0}", userInfo.PhoneNumber);
//    await model.BasicAckAsync(args.DeliveryTag, false);
//    await Task.CompletedTask;
//};

//await model.BasicConsumeAsync(queueName, false, consumer);

//Console.ReadKey();








//-------------------  جلسه چهارم تمرین 



var connectionFactory = new ConnectionFactory()
{
    HostName = "localHost",
    UserName = "guest",
    Password = "guest"
};

var connection = await connectionFactory.CreateConnectionAsync();

var model = await connection.CreateChannelAsync();

var queueName = "notifBy_phoneNum";
var exchangeName = "User_Header";

await model.QueueDeclareAsync(queueName, true, false, false, null);


await model.ExchangeDeclareAsync(exchangeName, ExchangeType.Headers, true);

var headers = new Dictionary<string, object>()
{
    { "logLevel","critical" },
    { "applicationName", "Lms" },
    {"x-match","all"}
};

await model.QueueBindAsync(queueName, exchangeName,"", headers);

var consumer = new AsyncEventingBasicConsumer(model);

consumer.ReceivedAsync += async (sender, args) =>
{
    var resultString = Encoding.UTF8.GetString(args.Body.ToArray());
    var userInfo = JsonSerializer.Deserialize<UserInfo>(resultString);

    Console.WriteLine("notif sent to mobileNum: {0}", userInfo.PhoneNumber);
    await model.BasicAckAsync(args.DeliveryTag, false);
    await Task.CompletedTask;
};

await model.BasicConsumeAsync(queueName, false, consumer);

Console.ReadKey();
