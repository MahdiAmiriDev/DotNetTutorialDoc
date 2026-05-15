using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Prototype
{
    internal class PermanentEmployee : Employee
    {
        public override Employee GetClone() => (PermanentEmployee)MemberwiseClone();        

        public override void ShowDetails()
        {
            Console.WriteLine("emp name is {0} \n emp dep is {1} \n emp type is {2}",Name,Department,Type);
        }
    }
}
