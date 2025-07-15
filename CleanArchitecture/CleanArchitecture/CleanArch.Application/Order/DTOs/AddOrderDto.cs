using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Order.DTOs
{
    public class AddOrderDto
    {
        public Guid ProductId { get; set; }
        public int Count { get; set; }

        public int Price { get; set; }
    }

    public class FinallyOrderDto
    {
        public int OrderId { get; set; }
    }

    public class OrderDto
    {
        public int Id { get; set; }
        public Guid ProductId { get; set; }
        public int Count { get; set; }

        public int Price { get; set; }

    }
}
