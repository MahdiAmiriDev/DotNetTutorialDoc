using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Order
{
    public class Order
    {
        public int Id { get; private set; }
        public Guid ProductId { get; private set; }
        public int Count { get; private set; }

        public int Price { get; private set; }

        public int TotalCount => Count * Price;

        public bool IsFinally { get; private set; }

        public DateTime FinallyDate { get; private set; }

        public Order(Guid productId, int count, int price)
        {


            Guard(count, price);

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

        private void Guard(int count, int price)
        {
            if (count < 1) throw new ArgumentException("count");

            if (price < 1) throw new ArgumentException("price");
        }
    }
}
