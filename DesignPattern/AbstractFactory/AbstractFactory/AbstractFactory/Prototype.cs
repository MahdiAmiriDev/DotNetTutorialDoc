using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Prototype : ICloneable
    {
        public string GardenName { get; set; }
             

        public Prototype(string gardenName)
        {
            GardenName = gardenName;
        }

        public object Clone()
        {
            return new Prototype(GardenName);
        }
    }
}
