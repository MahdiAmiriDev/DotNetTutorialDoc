namespace DesingPatternSamples.Creational.Simple_Factory
{
    internal class GalaxyS : Product
    {
        private string description;
        private string name;
        private int price;
        public GalaxyS(string description, string name, int price)
        {
            this.description = description;
            this.name = name;
            this.price = price;
        }

        string Product.GetDescription() => description;

        string Product.GetName() => name;

        int Product.GetPrice() => price;
    }
}
