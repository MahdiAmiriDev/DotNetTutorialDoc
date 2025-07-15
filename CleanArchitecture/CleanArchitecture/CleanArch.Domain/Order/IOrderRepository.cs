using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Order
{
    public interface IOrderRepository
    {
        List<Order> GetList();

        Order GetById(int id);

        void Add(Order order);

        void Update(Order order);

        void SaveChanges();
    }
}
