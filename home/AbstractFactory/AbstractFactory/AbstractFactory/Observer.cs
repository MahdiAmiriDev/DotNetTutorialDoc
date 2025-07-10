using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    record TempratureChange(float NewTemprature);

    interface IObserver<T>
    {
        void Update(T change);
    }

    interface ISubject<T>
    {
        public List<IObserver<T>> Observer { get; set; }

        void RegisterObserver(IObserver<T> observer);

        void RemoveObserver(IObserver<T> observer);

        Task NotifyAll();
    }

    class WeatherStation : ISubject<TempratureChange>
    {
        public List<IObserver<TempratureChange>> Observer { get; set; } = new List<IObserver<TempratureChange>>();

        private float CurrentTemprature;

        public Task ProcessWeather(float wahter)
        {
            CurrentTemprature = wahter;
            return NotifyAll();
        }

        public Task NotifyAll()
        {
            return Task.Run(() =>
            {
                foreach (var item in Observer)
                {
                    item.Update(new TempratureChange(CurrentTemprature));
                }
            });
        }

        public void RegisterObserver(IObserver<TempratureChange> observer)
        {
            Observer.Add(observer);
        }

        public void RemoveObserver(IObserver<TempratureChange> observer)
        {
            Observer.Remove(observer);
        }
    }

    class WeatherScreen : IObserver<TempratureChange>
    {
        public string Type { get; set; }

        public WeatherScreen(string type)
        {
            Type = type;
        }

        public void Update(TempratureChange change)
        {
            Console.WriteLine("the weather temprature change to {0}", change.NewTemprature);
        }
    }
}
