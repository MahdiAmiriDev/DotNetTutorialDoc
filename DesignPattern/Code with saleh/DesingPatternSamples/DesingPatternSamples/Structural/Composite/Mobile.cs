using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Composite
{
    internal class Mobile : Product
    {
        public string GetName()
        {
            return "samsung galaxy";
        }

        public double GetPrice()
        {
            return 1003;
        }
    }

    internal class LapTop : Product
    {
        public string GetName()
        {
            return "HP";
        }

        public double GetPrice()
        {
            return 10003;
        }
    }

    internal class Tv : Product
    {
        public string GetName()
        {
            return "LG";
        }

        public double GetPrice()
        {
            return 100203;
        }
    }
}
