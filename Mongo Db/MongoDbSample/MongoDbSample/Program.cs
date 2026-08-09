

using Microsoft.Extensions.Configuration;
using MongoDbSample.Models;
using MongoDbSample.Services;

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var settings = configuration
    .GetSection("MongoSettings")
    .Get<MongoSettings>();

var userService = new UserService(settings);

userService.Insert(new MongoDbSample.Entites.User()
{
    Name = "mahid",
    Family = "amiri",
    Phones = new List<string>() { "09337132998", "09034794740" }
});


userService.Insert(new MongoDbSample.Entites.User()
{
    Name = "hamid",
    Family = "noora",
    Phones = new List<string>() { "0933998", "03479470" }
});

var allUsers = userService.GetAll();

var firstUser = userService.Get(allUsers.First().Id);

firstUser.Phones = new List<string>();

userService.Update(firstUser);

userService.Delete(allUsers.Last().Id);

Console.ReadKey();



