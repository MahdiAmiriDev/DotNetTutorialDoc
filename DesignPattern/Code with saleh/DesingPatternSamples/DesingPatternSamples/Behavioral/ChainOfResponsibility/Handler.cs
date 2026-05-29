using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Behavioral.ChainOfResponsibility
{

    // Handler Abstract Class
    // The Default Chaining Behavior can be implemented inside the abstract handler class.
    public abstract class Handler
    {
        //The NextHandler will hold the reference of the next handler
        public Handler NextHandler;
        //Initializing NextHandler reference using the class constructor
        public void SetNextHandler(Handler NextHandler)
        {
            this.NextHandler = NextHandler;
        }
        //The following Method needs to be implemented by the Child handler Classes
        //The following method is going to handle a request.
        public abstract void DispatchNote(long requestedAmount);
    }
}
