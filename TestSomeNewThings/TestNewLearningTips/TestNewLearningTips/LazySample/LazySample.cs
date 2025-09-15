using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNewLearningTips.LazySample
{
    class GenerateSampleData
    {
        private List<string> strings;

        public GenerateSampleData()
        {
            strings = new List<string>(){"mahdi","parinaz","ali"};
        }

        public List<string> DataList => strings;
    }
}
