using System.Text;
using System.Text.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Utils;

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

await channel.QueueBindAsync(queueName, exchangeName, queueName);

var consumer = new AsyncEventingBasicConsumer(channel);

consumer.ReceivedAsync += async (sender, args) =>
{
    var result = JsonSerializer.Deserialize<OrderDto>(Encoding.UTF8.GetString(args.Body.ToArray()));

    if (result != null)
    {
        Console.WriteLine("order calc done");
        StringBuilder sb = new StringBuilder();

        result.CourseNameList.Select((x, index) =>
        {
            if (index == 0)
            {
                sb.Append(x);
            }
            else
            {
                sb.Append(" , " + x);
            }

            return x;

        }).ToList();

        Console.WriteLine("order list is {0}",sb.ToString());
    }
    await Task.CompletedTask;
};

await channel.BasicConsumeAsync(queueName,false,consumer);

Console.ReadKey();