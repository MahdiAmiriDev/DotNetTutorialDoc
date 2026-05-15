using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.FactoryMethod
{
    internal class CreditCardFactory : PaymentMethodFactory
    {

        private readonly string cardNumber;
        private readonly string cvv;
        private readonly string expireDate;

        public CreditCardFactory(string cardNumber,string cvv,string expireDate)
        {
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.expireDate = expireDate;
        }

        public PaymentMethod CreatePaymentMethod()
        {
            return new CreditCard(cardNumber,cvv,expireDate);
        }
    }
}
