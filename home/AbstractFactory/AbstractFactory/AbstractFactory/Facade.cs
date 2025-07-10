using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{


    interface IDevicePowerController
    {
        void TurnOn();

        void TurnOff();
    }

    public class Tv : IDevicePowerController
    {
        public void TurnOn()
        {
            Console.WriteLine("tv on");
        }

        public void TurnOff()
        {
            Console.WriteLine("tv off");
        }
    }

    public class SoundSystem : IDevicePowerController
    {
        public void TurnOn()
        {
            Console.WriteLine("sound system on");
        }

        public void TurnOff()
        {
            Console.WriteLine("sound system off");
        }
    }

    public class DvdPlayer : IDevicePowerController
    {
        public void TurnOn()
        {
            Console.WriteLine("Dvd player on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Dvd player off");
        }
    }

    public interface IHomeTheaterFacade
    {
        void WatchTv();

        void LetsDance();
    }

    public class HomeTheaterFacade
    {
        private DvdPlayer _dvdPlayer;
        private SoundSystem _soundSystem;
        private Tv _tv;
        public HomeTheaterFacade(DvdPlayer dvdPlayer, SoundSystem soundSystem, Tv tv)
        {
            _dvdPlayer = dvdPlayer;
            _soundSystem = soundSystem;
            _tv = tv;
        }

        void WatchTv()
        {
            _tv.TurnOn();
            _dvdPlayer.TurnOn();
            _soundSystem.TurnOff();
        }

        void LetsDance()
        {
            _tv.TurnOff();
            _dvdPlayer.TurnOff();
            _soundSystem.TurnOn();
        }


    }

}
