namespace DesingPatternSamples.Structural.Facade
{
    internal class OrderFacade
    {
        private readonly OrderVerification orderVerification;
        private readonly PaymentVerification paymentVerification;
        private readonly SubsidyVerification subsidyVerification;

        public OrderFacade()
        {
            orderVerification = new OrderVerification();
            paymentVerification = new PaymentVerification();
            subsidyVerification = new SubsidyVerification();
        }

        public static OrderFacade GetInstance() => new OrderFacade();

        public bool PlaceOrder(int orderId)
        {
            if (!orderVerification.VerifyOrder())
                return false;

            if (!paymentVerification.VerifyPayment())
                return false;

            if (!subsidyVerification.VerifySubsidy())
                return false;


            return true;
        }
    }
}
