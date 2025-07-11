

using CqrsSample.Product.Create;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using CqrsSample.Share;
using FluentValidation;

var services = new ServiceCollection();

services.AddMediatR(typeof(CreateProductCommand).Assembly);
services.AddValidatorsFromAssembly(typeof(CreateProductCommandValidation).Assembly);
services.AddScoped(typeof(IPipelineBehavior<,>), typeof(CommandValidatorBehavior<,>));

var serviceProvider = services.BuildServiceProvider();

var mediator = serviceProvider.GetRequiredService<IMediator>();

await mediator.Send(new CreateProductCommand("Iphone14ProMaxUsaLLAIsHere", 1900));

Console.ReadKey();



