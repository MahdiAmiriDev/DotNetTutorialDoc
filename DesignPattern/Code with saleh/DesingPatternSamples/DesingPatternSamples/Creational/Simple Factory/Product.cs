using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Simple_Factory
{
    internal interface Product
    {
        string GetName();

        string GetDescription();

        int GetPrice();
    }
}
