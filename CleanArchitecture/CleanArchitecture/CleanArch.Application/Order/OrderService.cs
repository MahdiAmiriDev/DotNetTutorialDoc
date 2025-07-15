using CleanArch.Application.Order.DTOs;
using CleanArch.Domain.Order;

namespace CleanArch.Application.Order
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void AddOrder(AddOrderDto addOrderDto)
        {
            _orderRepository.Add(new Domain.Order.Order(addOrderDto.ProductId, addOrderDto.Count, addOrderDto.Price));

            _orderRepository.SaveChanges();
        }

        public void FinallyOrder(FinallyOrderDto finallyOrderDto)
        {
            var order = _orderRepository.GetById(finallyOrderDto.OrderId);
            order.Finally();
            _orderRepository.Update(order);
            _orderRepository.SaveChanges();
        }

        public OrderDto GetOrderById(int id)
        {
            var order = _orderRepository.GetById(id);
            return new OrderDto()
            {
                Count = order.Count,
                Price = order.Price,
                ProductId = order.ProductId,
                Id = order.Id
            };
        }

        public List<OrderDto> GetOrders()
        {
            return _orderRepository.GetList().Select(x => new OrderDto()
            {
                Count = x.Count,
                Price = x.Price,
                ProductId = x.ProductId,
                Id = x.Id
            }).ToList();
        }
    }
}
