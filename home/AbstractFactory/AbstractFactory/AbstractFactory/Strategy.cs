using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AbstractFactory
{
    interface IHealthStrategy
    {
        public void Execute();
    }

    class Diet : IHealthStrategy
    {
        public void Execute()
        {
            WriteLine("starting diet strategy");
        }
    }

    class RegularExercies : IHealthStrategy
    {
        public void Execute()
        {
            WriteLine("starting regular strategy");
        }
    }

    class MentalCare : IHealthStrategy
    {
        public void Execute()
        {
            WriteLine("starting mental strategy");
        }
    }


    internal interface IHealthContext
    {
        void SetStrategy(IHealthStrategy strategy);

        void ExecuteStrategy();
    }

    class HealthContext : IHealthContext
    {
        private IHealthStrategy _strategy;

        public void ExecuteStrategy()
        {
            if (_strategy == null)
            {
                WriteLine("strategy is null !");
                return;
            }

            _strategy.Execute();
        }

        public void SetStrategy(IHealthStrategy strategy)
        {
            _strategy = strategy;
        }


    }

}
