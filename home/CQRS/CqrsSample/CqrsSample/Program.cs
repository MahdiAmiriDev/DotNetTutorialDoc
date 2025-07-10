

using CqrsSample.Product.Create;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var services = new ServiceCollection();

services.AddMediatR(typeof(CreateProductCommand).Assembly);


var serviceProvider = services.BuildServiceProvider();

var mediator = serviceProvider.GetRequiredService<IMediator>();

await mediator.Send(new CreateProductCommand("Iphone", 200));

Console.ReadKey();



