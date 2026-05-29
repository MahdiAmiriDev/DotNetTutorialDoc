using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Flyweight
{
    internal class SharedCharacter : Character
    {
        private readonly int height;
        private readonly int weight;
        private readonly string hairColor;

        public SharedCharacter(int height, int weight, string hairColor)
        {
            this.height = height;
            this.weight = weight;
            this.hairColor = hairColor;
        }

        public void Render(string name)
        {
            Console.WriteLine("render {3} character with height:{0}, weight:{1} and {2} hair color..", height, weight, hairColor, name);
        }
    }
}
