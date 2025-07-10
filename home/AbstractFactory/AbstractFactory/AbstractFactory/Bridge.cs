using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //مشخص کننده این که بازی چیه
    public abstract class Game
    {
        protected IPlatform _platform;

        public Game(IPlatform platform)
        {
            _platform = platform;
        }

        public abstract void Play();
    }

    public class RacingGame: Game
    {
        public RacingGame(IPlatform platform) : base(platform)
        {
        }

        public override void Play()
        {
            _platform.Render("racing game");
        }
    }

    public class ShootingGame: Game
    {
        public ShootingGame(IPlatform platform) : base(platform)
        {
        }

        public override void Play()
        {
            _platform.Render("shooting game");
        }
    }

    public interface IPlatform
    {
        public void Render(string gameType);
    }

    public class PcPlatform : IPlatform
    {
        public void Render(string gameType)
        {
            Console.WriteLine($"rendring on {gameType} on pc");
        }
    }

    public class ConsolePlatform : IPlatform
    {
        public void Render(string gameType)
        {
            Console.WriteLine($"rendring on {gameType} on console");
        }
    }

    public class MobilePlatform : IPlatform
    {
        public void Render(string gameType)
        {
            Console.WriteLine($"rendring on {gameType} on mobile");
        }
    }

    public enum PlatformType
    {
        Pc,Console,Mobile
    }

}
