using CleanArch.Domain.OrderAgg.Services;

namespace CleanArch.Domain.Order;

public class OrderItem: BaseEntity
{
    public OrderItem(int id, int orderId, int count, int productId)
    {
        Id = id;
        OrderId = orderId;
        Count = count;
        ProductId = productId;
    }

    public int Id { get; private set; }
    public int OrderId { get; private set; }
    public int Count { get; private set; }
    public int ProductId { get; set; }

}