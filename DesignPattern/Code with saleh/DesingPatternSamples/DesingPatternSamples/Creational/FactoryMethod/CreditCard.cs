using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.FactoryMethod
{
    internal class CreditCard : PaymentMethod
    {
        private readonly string cardNumber;
        private readonly string cvv;
        private readonly string expireDate;

        public CreditCard(string cardNumber, string cvv, string expireDate)
        {
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.expireDate = expireDate;
        }

        public void ProcessPayment()
        {
            Console.WriteLine("credit card payment done successfull with card num {0} and cvv {1} and exDate {2}",cardNumber,cvv,expireDate);
        }
    }
}
