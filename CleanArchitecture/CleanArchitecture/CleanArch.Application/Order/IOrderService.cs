using CleanArch.Application.Order.DTOs;

namespace CleanArch.Application.Order;

public interface IOrderService
{
    void AddOrder(AddOrderDto addOrderDto);

    void FinallyOrder(FinallyOrderDto finallyOrderDto);

    OrderDto GetOrderById(int id);

    List<OrderDto> GetOrders();

}