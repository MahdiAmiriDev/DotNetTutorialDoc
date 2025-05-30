using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public interface ICar
    {
        int GetCost();

        string GetDescription();
    }

    class BasicCar : ICar
    {
        protected int Cost;
        protected string Description;

        public BasicCar(int cost, string description)
        {
            Cost = cost;
            Description = description;
        }

        public int GetCost()
        {
            return Cost;
        }

        public string GetDescription()
        {
            return Description;
        }
    }

    class CarDecorator : ICar
    {
        protected ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }
        public virtual int GetCost()
        {
            return _car.GetCost();
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }
    }

    class SportDecorator : CarDecorator
    {
        public SportDecorator(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "sports package";
        }

        public override int GetCost()
        {
            return base.GetCost() + 1000;
        }
    }

    class LuxuryDecorator : CarDecorator
    {
        public LuxuryDecorator(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "LuxuryDecorator package";
        }

        public override int GetCost()
        {
            return base.GetCost() + 100000;
        }
    }
}
