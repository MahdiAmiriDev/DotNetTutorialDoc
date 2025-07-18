using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Shared
{
    /// <summary>
    ///تمامی ویژگی های ValueObject را داریم
    /// 
    /// identity less
    /// بدون id
    /// </summary>
    public class Mony
    {

        /// <summary>
        /// richModel
        /// self validation
        /// </summary>
        /// <param name="rialValue"></param>
        /// <exception cref="InvalidDataException"></exception>
        public Mony(int rialValue)
        {
            if (rialValue < 0)
                throw new InvalidDataException();

            Value = rialValue;
        }

        /// <summary>
        /// Rial - immutable
        /// </summary>
        public int Value { get; private set; }

        public static Mony FromRial(int value) => new Mony(value);

        public static Mony FromToman(int value) => new Mony(value * 10);

        /// <summary>
        /// combinable
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Mony operator +(Mony left, Mony right) => new Mony(left.Value + right.Value);
        public static Mony operator -(Mony left, Mony right) => new Mony(left.Value - right.Value);

        /// <summary>
        /// attribute base equality
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(Mony left, Mony right) => left.Value == right.Value;
        public static bool operator !=(Mony left, Mony right) => left.Value != right.Value;
    }
}
