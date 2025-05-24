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

        public List<Flower> Flowers { get; set; }

        public Prototype(List<Flower> flowers , string name)
        {
            Flowers = flowers.Select(x => new Flower(name)).ToList();
            GardenName = name;
        }

        public Prototype()
        {

        }


        public Prototype(string gardenName)
        {
            GardenName = gardenName;
        }

        public object Clone()
        {
            return new Prototype(GardenName)
            {
                Flowers = this.Flowers.Select(f => (Flower)f.Clone()).ToList()
            };
        }
    }

    public class Flower : ICloneable
    {
        public String Name { get; set; }

        public Flower(string name)
        {
            Name = name;
        }

        public object Clone()
        {
            return new Flower(Name);
        }
    }

    public interface IDeepCopy<T>
    {
        T DeepCopy();
    }

    public class PrototypeDeepCopy : IDeepCopy<PrototypeDeepCopy>
    {
        public string GardenName { get; set; }

        public List<Flower> Flowers { get; set; }

        public PrototypeDeepCopy(List<Flower> flowers, string name)
        {
            Flowers = flowers.Select(x => new Flower(name)).ToList();
            GardenName = name;
        }

        public PrototypeDeepCopy()
        {

        }


        public PrototypeDeepCopy(string gardenName)
        {
            GardenName = gardenName;
        }

        public object Clone()
        {
            return new Prototype(GardenName)
            {
                Flowers = this.Flowers.Select(f => (Flower)f.Clone()).ToList()
            };
        }

        public PrototypeDeepCopy DeepCopy()
        {
            return new PrototypeDeepCopy(this.GardenName)
            {
                Flowers = this.Flowers.Select(f => (Flower)f.Clone()).ToList()
            };
        }
    }

}

