namespace DesingPatternSamples.Behavioral.Strategy
{
    internal class SilverDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.1;
        }
    }
}
