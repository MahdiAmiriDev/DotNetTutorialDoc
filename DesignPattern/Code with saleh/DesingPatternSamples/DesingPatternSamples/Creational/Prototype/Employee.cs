using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Prototype
{
    internal abstract class Employee
    {
        public string Name { get; set; }

        public string Department { get; set; }

        public string Type { get; set; }

        public abstract Employee GetClone();

        public abstract void ShowDetails();
    }
}
