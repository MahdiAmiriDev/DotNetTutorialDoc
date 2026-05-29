using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Behavioral.Mediator
{
    public interface IFacebookGroupMediator
    {
        void SendMessage(string message, User user);

        void RegisterUser(User user);
    }

}
