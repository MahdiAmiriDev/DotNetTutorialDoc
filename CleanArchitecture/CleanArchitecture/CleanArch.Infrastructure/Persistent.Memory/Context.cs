
using CleanArch.Domain.Order;
using CleanArch.Domain.Product;

namespace CleanArch.Infrastructure.Persistent.Memory
{
    public class Context
    {
        public List<Product> Products { get; set; }
        public List<Domain.Order.Order> Orders { get; set; }
    }
}
