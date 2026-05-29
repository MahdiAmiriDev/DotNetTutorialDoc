using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Flyweight
{
    internal class CharacterFactory
    {
        private Dictionary<string, Character> _characterList = new();

        public CharacterFactory()
        {

        }

        public Character GetSharedCharacter(int height, int weight, string hairColor)
        {
            var key = $"{height}-{weight}-{hairColor}";

            if (!_characterList.ContainsKey(key))
            {
                Console.WriteLine("creating new character.... !\n");
                _characterList.Add(key, new SharedCharacter(height, weight, hairColor));
            }

            return _characterList[key];
        }
    }
}
