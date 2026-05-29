using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Flyweight
{
    internal class CharacterClient
    {
        private string name;

        private Character sharedCharacter;

        public CharacterClient(string name, CharacterFactory characterFactory, int height, int weight, string hairColor)
        {
            this.name = name;
            sharedCharacter = characterFactory.GetSharedCharacter(height, weight, hairColor);
        }


        public void Render()
        {
            sharedCharacter.Render(name);
        }
    }
}
