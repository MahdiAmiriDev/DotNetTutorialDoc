using System.Linq;


namespace DesingPatternSamples.Structural.Composite
{
    internal class ProductCatalog : Product
    {
        private readonly List<Product> _products = new List<Product>();

        public void PrintSumOfPrice()
        {
            double priceSum = 0;

            _products.Select(s =>
            {
                priceSum += s.GetPrice();                
                return s;
            }).ToList();

            Console.WriteLine("sum of price is {0}", priceSum);
        }

        public void PrintNames()
        {

            Console.WriteLine("product names :");
            Console.WriteLine(string.Join("\n", _products.Select(s => s.GetName())));
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public string GetName()
        {
            return "Product catalog";
        }

        public double GetPrice()
        {
            return 0.0;
        }
    }
}
