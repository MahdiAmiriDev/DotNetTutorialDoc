using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.StaticFactory
{
    internal class DataProcessor
    {
        public static DataReader CreateDataReader(string fileType)
        {
            return fileType switch
            {
                "xml" => new XmlReader(),
                "json" => new JsonReader(),
                _ => throw new NotSupportedException()
            };
        }
    }
}
