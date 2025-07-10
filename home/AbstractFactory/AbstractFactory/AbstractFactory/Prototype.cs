using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AbstractFactory
{
    [Serializable]
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

        public Flower()
        {
            
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

    public static class ExtensionMethod
    {
        public static async Task<T?> DeepCopyJsonAsync<T> (this T self)
        {
            using var ms = new MemoryStream ();

            await JsonSerializer.SerializeAsync<T>(ms, self);

            ms.Position = 0;

            return await JsonSerializer.DeserializeAsync<T>(ms);

        }

        public static T? DeepCopyXml<T>(this T self)
        {
            using var ms = new MemoryStream();

            var xml = new XmlSerializer(typeof(T));

            xml.Serialize(ms,self);

            ms.Position = 0;

            return (T)xml.Deserialize(ms);

        }
    }

}

