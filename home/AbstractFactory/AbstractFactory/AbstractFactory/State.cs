using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface IState
    {
        void SetContext(AudioPlayer context);
        void Play();
        void Stop();
        void Pause();
    }

    class AudioPlayer
    {
        private IState _state;

        public AudioPlayer(IState state)
        {
            _state = state;
            SetTransitionTo(state);
        }

        public void SetTransitionTo(IState state)
        {
            _state = state;
            _state.SetContext(this);
        }

        public void Play()
        {
            _state.Play();
        }
        public void Pause()
        {
            _state.Pause();
        }
        public void Stop()
        {
            _state.Stop();
        }
    }


    class PlayState : IState
    {
        private AudioPlayer _audioPlayer;

        public void SetContext(AudioPlayer context)
        {
            _audioPlayer = context;
        }

        public void Play()
        {
            Console.WriteLine("already playing");
        }

        public void Stop()
        {
            Console.WriteLine("playing stop");
        }

        public void Pause()
        {
            Console.WriteLine("playing pause");
        }
    }

    class StopState:IState
    {
        private AudioPlayer _context;

        public void SetContext(AudioPlayer context)
        {
            _context = context;
        }

        public void Play()
        {
            Console.WriteLine("start playing");
        }

        public void Stop()
        {
            Console.WriteLine("Stop state activated");
            _context.SetTransitionTo(new StopState());
        }

        public void Pause()
        {
            Console.WriteLine("playing pause");
        }
    }


    class PauseState : IState
    {
        private AudioPlayer _context;

        public void SetContext(AudioPlayer context)
        {
            _context = context;
        }

        public void Play()
        {
            Console.WriteLine("playing start");
        }

        public void Stop()
        {
            Console.WriteLine("playing stop");
        }

        public void Pause()
        {
            Console.WriteLine("Pause state activated");
            _context.SetTransitionTo(new PauseState());
        }
    }
}
