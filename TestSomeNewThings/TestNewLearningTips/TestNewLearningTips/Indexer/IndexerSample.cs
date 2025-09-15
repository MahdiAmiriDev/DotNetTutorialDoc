using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestNewLearningTips.Indexer
{
    public class IndexerSample
    {
        public Dictionary<int, string> Dictionary = new();

        public string this[string name]
        {
            get
            {
                if (Dictionary.ContainsValue(name))
                {
                    var keyValue = Dictionary
                        .FirstOrDefault(x => x.Value == name);

                    return Dictionary[keyValue.Key];
                }

                return string.Empty;
            }

            set
            {
                var randomNumbers = Enumerable.Range(1, 30).ToList();

                Dictionary.Add(randomNumbers[name.Length], name);
            }
        }

        public string this[int index]
        {
            get
            {
                if (Dictionary.ContainsKey(index))
                {
                    return Dictionary[index];
                }

                return string.Empty;
            }

            set => Dictionary.Add(index, index.ToString());
        }

    }
}
