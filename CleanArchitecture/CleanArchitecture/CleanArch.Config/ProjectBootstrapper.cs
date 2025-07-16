using CleanArch.Application.Order;
using CleanArch.Contract;
using CleanArch.Domain.Order;
using CleanArch.Infrastructure;
using CleanArch.Infrastructure.Persistent.Memory;
using CleanArch.Infrastructure.Persistent.Memory.Order;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Config
{
    public class ProjectBootstrapper
    {
        public static void Init(IServiceCollection services)
        {
            services.AddSingleton<Context>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ISmsService, SendSmsService>();
            //services.AddScoped<IProductRepository,ProductRepository>();
            //services.AddScoped<IProductService,ProductService>();
        }
    }
}
