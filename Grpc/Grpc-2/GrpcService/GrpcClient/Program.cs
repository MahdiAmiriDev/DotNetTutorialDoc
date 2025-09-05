

using Grpc.Core;
using Grpc.Net.Client;
using GrpcDemo;
using GrpcDemo.Protos;


//var channel = GrpcChannel.ForAddress("https://localhost:7110");
//var client = new Greeter.GreeterClient(channel);

//var reply = await client.SayHelloAsync(new HelloRequest()
//{
//    Name = "Mahdi"
//});

//Console.WriteLine(reply.Message);



//-------------------------------------------- 2 ---------------------------------

//var customerGrpcChannel = GrpcChannel.ForAddress("https://localhost:7110");

//var customerClient = new Customer.CustomerClient(customerGrpcChannel);

//var response = await customerClient.GetCustomerInformationInStringFormatAsync(
//    new CustomerRequest()
//    {
//        Name = "Parinaz",
//        Family = "Karimi",
//        Age = 21
//    });

//Console.ForegroundColor = ConsoleColor.Magenta;
////Console.BackgroundColor = ConsoleColor.White;

//for (int i = 0; i < 200; i++)
//{
//    Console.WriteLine(response.Information);

//}


//-------------------------------------------- 3 ---------------------------------


var customerGrpcChannel = GrpcChannel.ForAddress("https://localhost:7110");

var customerClient = new Customer.CustomerClient(customerGrpcChannel);

using (var call = customerClient.GetCustomers(new GetCusmersRequest()))
{
    while (await call.ResponseStream.MoveNext())
    {
        var c = call.ResponseStream.Current;

        Console.WriteLine($"{c.Family} {c.Name}");
    }
}



Console.ReadKey();