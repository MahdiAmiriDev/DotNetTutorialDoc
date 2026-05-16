using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Adapter
{
    internal class PaymentProcessor
    {
        private readonly PaymentMethod _paymentMethod;

        public PaymentProcessor(PaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }


        public void Process(int amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }
}
