using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.StaticFactory
{
    internal class XmlReader : DataReader
    {
        public void ReadData(string path)
        {
            Console.Write("the file path of xml is {0}", path);
        }
    }
}
