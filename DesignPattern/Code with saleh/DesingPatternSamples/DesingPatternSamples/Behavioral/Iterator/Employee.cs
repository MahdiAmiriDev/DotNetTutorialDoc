using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Behavioral.Iterator
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(string name, int id)
        {
            Id = id;
            Name = name;
        }
    }
}
