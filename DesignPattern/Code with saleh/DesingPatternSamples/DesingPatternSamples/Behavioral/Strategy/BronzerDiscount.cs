namespace DesingPatternSamples.Behavioral.Strategy
{
    internal class BronzerDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.05;
        }
    }
}
