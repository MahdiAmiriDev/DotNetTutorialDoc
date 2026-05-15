using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Simple_Factory
{
    internal class TV : Product
    {
        private string description;
        private string name;
        private int price;
        public TV(string description, string name, int price)
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
