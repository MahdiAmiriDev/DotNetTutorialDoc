using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

	public interface IPaymentGateway
	{
		void ProcessPayment(decimal amount);
	}

	public class PasargardPayment
	{
        public void SendPaymentRequestToPasargardBank(decimal amount)
        {
            Console.WriteLine("sending {0} reial to back for pay in pasargar gateway",amount);
        }
	}

	public class TejaratPayment
	{
        public void SendPaymentRequestToTejaratBank(decimal amount)
        {
            Console.WriteLine("sending {0} reial to back for pay in tejarat gateway", amount);
        }
    }

    public class PasargardAdapter : IPaymentGateway
    {
        private PasargardPayment _payment;

        public PasargardAdapter(PasargardPayment pasargardPayment)
        {
            _payment = pasargardPayment;
        }

        public void ProcessPayment(decimal amount)
        {
            _payment.SendPaymentRequestToPasargardBank(amount);
        }
    }

    public class TejaratAdapter : IPaymentGateway
    {

        private TejaratPayment _payment;

        public TejaratAdapter(TejaratPayment payment)
        {
            _payment = payment;
        }

        void IPaymentGateway.ProcessPayment(decimal amount)
        {
            _payment.SendPaymentRequestToTejaratBank(amount);
        }
    }


}
