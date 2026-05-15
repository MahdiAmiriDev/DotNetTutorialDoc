using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Abstract_Factory
{
    internal class WindowsButton : Button
    {
        public void RenderButton()
        {
            Console.WriteLine("windows button is ready !");
        }
    }
}
