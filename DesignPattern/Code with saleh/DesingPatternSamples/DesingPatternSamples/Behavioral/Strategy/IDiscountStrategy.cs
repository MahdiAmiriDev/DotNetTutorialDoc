using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DesingPatternSamples.Behavioral.Strategy
{
    internal interface IDiscountStrategy
    {
        double CalculateDiscount(double price);
    }
}
