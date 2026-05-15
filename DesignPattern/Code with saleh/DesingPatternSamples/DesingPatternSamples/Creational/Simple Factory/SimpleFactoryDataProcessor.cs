using DesingPatternSamples.Creational.Simple_Factory;



namespace DesingPatternSamples.Creational.StaticFactory
{
    internal class SimpleFactoryDataProcessor
    {

        public Product CreateProduct(string prodcutType,string description, string name, int price)
        {
            return prodcutType switch
            {
                "TV" => new TV(description, name, price),
                "GalaxyS" => new GalaxyS(description, name, price),
                _ => throw new NotSupportedException()
            };
        }
    }
}
