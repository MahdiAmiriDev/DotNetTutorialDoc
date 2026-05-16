using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Adapter
{
    internal interface PaymentMethod
    {
        void ProcessPayment(int amount);
    }
}
