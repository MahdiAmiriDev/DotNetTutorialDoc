namespace DesingPatternSamples.Behavioral.Strategy
{
    internal class ShoppingCard
    {

        private List<double> itemsPrice = new List<double>();

        private IDiscountStrategy strategy;

        public void SetDiscountStrategy(IDiscountStrategy strategy)
        {
            this.strategy = strategy;
        }


        public void AddItemToShoopingCard(double price)
        {
            itemsPrice.Add(price);
        }


        public double CalculatePriceWithDiscount()
        {
            double calculatedPrice = 0;

            foreach (double item in itemsPrice)
            {
                calculatedPrice += strategy.CalculateDiscount(item);
            }

            return calculatedPrice;
        }

    }
}
