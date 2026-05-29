using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Bridge
{
    internal class SamsungLedTv: ILedTv
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Samsung TV");
        }
    }
}
