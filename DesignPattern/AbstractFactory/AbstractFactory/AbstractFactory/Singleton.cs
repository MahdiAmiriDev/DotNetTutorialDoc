using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Planet
    {
        public int ContinetNumber { get; set; }

        public string Name { get; set; }

        public Planet(string name, int continetNumber)
        {
            Name = name;
            ContinetNumber = continetNumber;
        }
    }

    public class Mars : Planet
    {

        public int Population { get; set; }

        public static Mars Instance { get; set; }

        public Mars() : base("mars", 5)
        {
        }

        public static Mars GetInstance()
        {
            if (Instance == null)
                Instance = new Mars();

            return Instance;
        }
    }
}
