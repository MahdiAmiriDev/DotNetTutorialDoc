using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Order
    {
        public string OrderId { get; set; }

        public bool IsValidated { get; set; }
        public bool IsInStock { get; set; }
        public bool IsPaymentProcessed { get; set; }
        public List<Object> Products { get; set; }
    }

    abstract class OrderHandler
    {
        private OrderHandler _nextHandler;

        public void SetNextHandler(OrderHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void HandleOrder(Order order)
        {
            if (CanProcess(order))
            {
                ProcessOrder(order);
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleOrder(order);
            }
        }

        public abstract bool CanProcess(Order order);

        public abstract void ProcessOrder(Order order);
    }

    class ValidationHandler : OrderHandler
    {
        public override bool CanProcess(Order order)
        {
            return order.IsValidated;
        }

        public override void ProcessOrder(Order order)
        {
            Console.WriteLine("validation order");
            order.IsValidated = true;
            Console.WriteLine("validation validated");
        }
    }

    class PaymentHandler : OrderHandler
    {
        public override bool CanProcess(Order order)
        {
            return order.IsPaymentProcessed;
        }

        public override void ProcessOrder(Order order)
        {
            Console.WriteLine("payment order");
            order.IsPaymentProcessed = true;
            Console.WriteLine("payment validated");
        }
    }

    class InventoryHandler : OrderHandler
    {
        public override bool CanProcess(Order order)
        {
            return order.IsInStock;
        }

        public override void ProcessOrder(Order order)
        {
            Console.WriteLine("Inventory order process");
            order.IsInStock = true;
            Console.WriteLine("Inventory validated");
        }
    }
}
