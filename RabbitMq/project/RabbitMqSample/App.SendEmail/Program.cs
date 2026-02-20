using System.Text;
using System.Text.Json;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using Utils;

//var connectionFactory = new ConnectionFactory()
//{
//    HostName = "localHost",
//    UserName = "guest",
//    Password = "guest"
//};

//var connection = await connectionFactory.CreateConnectionAsync();

//var model = await connection.CreateChannelAsync();

//var queueName = "notifBy_Email";
//var exchangeName = "broadCastUser_register";

//await model.QueueDeclareAsync(queueName, true, false, false, null);
//await model.ExchangeDeclareAsync(exchangeName, ExchangeType.Fanout, true);

//await model.QueueBindAsync(queueName, exchangeName, "");

//var consumer = new AsyncEventingBasicConsumer(model);

//consumer.ReceivedAsync += async (sender, args) =>
//{
//    var resultString = Encoding.UTF8.GetString(args.Body.ToArray());
//    var userInfo = JsonSerializer.Deserialize<UserInfo>(resultString);
//    Console.WriteLine("notif sent to email: {0}", userInfo.Email);
//    await model.BasicAckAsync(args.DeliveryTag, false);
//    await Task.CompletedTask;
//};

//await model.BasicConsumeAsync(queueName, false, consumer);

//Console.ReadKey();









//--------------------- تمرین جلسه سوم


//var connectionFactory = new ConnectionFactory()
//{
//    HostName = "localHost",
//    UserName = "guest",
//    Password = "guest"
//};

//var connection = await connectionFactory.CreateConnectionAsync();

//var model = await connection.CreateChannelAsync();

//var queueName = "notifBy_Email";
//var exchangeName = "User_Topic";

//await model.QueueDeclareAsync(queueName, true, false, false, null);
//await model.ExchangeDeclareAsync(exchangeName, ExchangeType.Topic, true);

//await model.QueueBindAsync(queueName, exchangeName, "email.*");

//var consumer = new AsyncEventingBasicConsumer(model);

//consumer.ReceivedAsync += async (sender, args) =>
//{
//    var resultString = Encoding.UTF8.GetString(args.Body.ToArray());
//    var userInfo = JsonSerializer.Deserialize<UserInfo>(resultString);
//    Console.WriteLine("notif sent to email: {0}", userInfo.Email);
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

var queueName = "notifBy_Email";
var exchangeName = "User_Header";

await model.QueueDeclareAsync(queueName, true, false, false, null);
await model.ExchangeDeclareAsync(exchangeName, ExchangeType.Headers, true);

var headers = new Dictionary<string, object>()
{
    { "logLevel","normal" },
    { "applicationName", "Lms" },
    {"x-match","any"}
};

await model.QueueBindAsync(queueName, exchangeName, "", headers);

var consumer = new AsyncEventingBasicConsumer(model);

consumer.ReceivedAsync += async (sender, args) =>
{
    var resultString = Encoding.UTF8.GetString(args.Body.ToArray());
    var userInfo = JsonSerializer.Deserialize<UserInfo>(resultString);
    Console.WriteLine("notif sent to email: {0}", userInfo.Email);
    await model.BasicAckAsync(args.DeliveryTag, false);
    await Task.CompletedTask;
};

await model.BasicConsumeAsync(queueName, false, consumer);

Console.ReadKey();