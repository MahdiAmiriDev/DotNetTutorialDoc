using CleanArch.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Order.Services;
using CleanArch.Domain.OrderAgg.Services;

namespace CleanArch.Domain.Order
{
    public class Order: AggregateRoot
    {
        public int Id { get; private set; }
        public Guid ProductId { get; private set; }
        public int Count { get; private set; }

        public Mony Price { get; private set; }

        public int TotalCount => Count * Price.Value;

        public bool IsFinally { get; private set; }

        public DateTime FinallyDate { get; private set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public Order(Guid productId, int count, Mony price)
        {


            Guard(count);

            ProductId = productId;
            Count = count;
            Price = price;
        }

        public void Finally()
        {
            IsFinally = true;
            FinallyDate = DateTime.Now;
        }

        public void IncreaseCount(int count)
        {
            if (Count <= 0) throw new ArgumentException("count");

            this.Count += count;
        }

        private void Guard(int count)
        {
            if (count < 1) throw new ArgumentException("count");

        }

        public void AddItem(int productId, int count, int something, IOrderDomainService orderDomainService)
        {
            if (!orderDomainService.IsProductExists(productId))
                throw new Exception();

            OrderItems.Add(new OrderItem(23,Id, count,productId));
        }
    }
}
