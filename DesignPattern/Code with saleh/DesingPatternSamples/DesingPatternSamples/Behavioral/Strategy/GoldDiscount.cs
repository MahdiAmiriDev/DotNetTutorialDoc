namespace DesingPatternSamples.Behavioral.Strategy
{
    internal class GoldDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.2;
        }
    }
}
