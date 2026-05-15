using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Abstract_Factory
{
    internal class WindowsCheckBox : CheckBox
    {
        public void RenderCheckBox()
        {
            Console.WriteLine("windows checkbox is ready !");
        }
    }
}
