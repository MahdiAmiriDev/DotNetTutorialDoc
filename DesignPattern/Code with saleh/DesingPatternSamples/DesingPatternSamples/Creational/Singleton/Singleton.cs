using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Singleton
{
    internal sealed class Singleton
    {
        private static Singleton Instance = null;

        private static int Counter;

        private Singleton()
        {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        public static Singleton GetInstance()
        {
            if (Instance == null)
                Instance = new Singleton();

            return Instance;
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
