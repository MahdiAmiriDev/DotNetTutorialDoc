using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Contract;
using CleanArch.Domain.Order;

namespace CleanArch.Infrastructure.Persistent.Memory.Order
{
    public class OrderRepository : IOrderRepository
    {
        private Context _context;
        private ISmsService _smsService;
        public OrderRepository(Context context, ISmsService smsService)
        {
            _context = context;
            _smsService = smsService;
        }

        public List<Domain.Order.Order> GetList()
        {
            return _context.Orders;
        }

        public Domain.Order.Order GetById(int id)
        {
            return _context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Domain.Order.Order order)
        {
            _context.Orders.Add(order);
        }

        public void Update(Domain.Order.Order order)
        {
            _context.Orders.Remove(_context.Orders.FirstOrDefault(x => x.Id == order.Id));
            _context.Orders.Add(order);
        }

        public void SaveChanges()
        {
            Console.WriteLine("successfully saved");
            _smsService.SendSms(new SendSmsDto()
            {
                Number = 091266587,
                Text = "hellooooo"
            });
        }
    }
}
