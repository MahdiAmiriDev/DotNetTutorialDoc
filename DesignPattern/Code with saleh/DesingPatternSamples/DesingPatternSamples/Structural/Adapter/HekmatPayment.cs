using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Adapter
{
    internal class HekmatPayment
    {
        public void DoHybridPayment(string amount)
        {
            Console.WriteLine("operation done successfully with amount {0}",amount);
        }
    }
}
