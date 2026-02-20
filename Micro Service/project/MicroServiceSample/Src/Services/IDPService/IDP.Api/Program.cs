using System.Reflection;
using Asp.Versioning;
using IDP.Application.GrpcService;
using IDP.Application.Handler.Command.User;
using IDP.Domain.IRepository.Command;
using IDP.Infra.Data;
using IDP.Infra.Repository.Command;
using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddStackExchangeRedisCache(option =>
{
    option.Configuration = "localhost:6379";
});
//register mediatR
builder.Services.AddMediatR(typeof(UserHandler).GetTypeInfo().Assembly);
builder.Services.AddScoped<IOptRedisRepository, OtpRedisRepository>();

builder.Services.AddDbContext<ShopDbContext>();


//Add Cap Package and register.
builder.Services.AddCap(option =>
{
    option.UseEntityFramework<ShopDbContext>();
    option.UseDashboard(path => path.PathMatch = "/cap");
    option.UseRabbitMQ(opt =>
    {
        opt.ConnectionFactoryOptions = options =>
        {
            options.Ssl.Enabled = false;
            options.HostName = "localhost";
            options.UserName = "guest";
            options.Password = "guest";
            options.Port = 5672;
        };
    });
    option.FailedRetryCount = 5;
    option.CollectorCleaningInterval = 5;
});

//Add MassTransit
builder.Services.AddMassTransit(masConfig =>
{
    //masConfig.AddEntityFrameworkOutbox<ShopDbContext>(o =>
    //{
    //    o.QueryDelay = TimeSpan.FromSeconds(30);
    //    o.UseSqlServer().UseBusOutbox();
    //});

    masConfig.SetKebabCaseEndpointNameFormatter();
    masConfig.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host(new Uri("rabbitmq://localhost"), h =>
        {
            h.Username("guest");
            h.Password("guest");
        });
        cfg.UseMessageRetry(r =>
            r.Exponential(10,
                TimeSpan.FromSeconds(5),
                TimeSpan.FromSeconds(10),
                TimeSpan.FromSeconds(10)));
        cfg.ConfigureEndpoints(context);
    });
});


//Add Api Versioning
builder.Services.AddApiVersioning(options =>
    {
        options.DefaultApiVersion = new ApiVersion(1);
        options.ReportApiVersions = true;
        options.AssumeDefaultVersionWhenUnspecified = true;
        options.ApiVersionReader = ApiVersionReader.Combine(
            new UrlSegmentApiVersionReader(),
            new HeaderApiVersionReader("X-Api-Version"));
    }).AddMvc() // This is needed for controllers
    .AddApiExplorer(options =>
    {
        options.GroupNameFormat = "'v'V";
        options.SubstituteApiVersionInUrl = true;
    });


builder.Services.AddGrpc();

//استفاده از کلاس لایه auth
//و تزریق به پروژه api
Auth.Extensions.AddJwt(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGrpcService<UserGrpcService>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
