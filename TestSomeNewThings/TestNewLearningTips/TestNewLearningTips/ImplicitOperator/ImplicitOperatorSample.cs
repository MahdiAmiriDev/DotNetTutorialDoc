using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNewLearningTips.ImplicitOperator
{
    public class Rial
    {
        public int Value { get; set; }

        public Rial(int value)
        {
            Value = value;
        }


        public static implicit operator Toman(Rial rial)
        {
            return new Toman(rial.Value);
        }

    }

    public class Toman
    {
        public int Value { get; set; }

        public Toman(int value)
        {
            Value = value;
        }
    }
}
