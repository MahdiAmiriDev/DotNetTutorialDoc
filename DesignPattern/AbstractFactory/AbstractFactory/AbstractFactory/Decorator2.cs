using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public record WebRequest(string body, bool isAuthenticated);


    public interface IBackendRequestHandler
    {
        void Handle(WebRequest request);
    }


    public class BaseBackend : IBackendRequestHandler
    {
        public void Handle(WebRequest request)
        {
            Console.WriteLine($"proccessing request {request.body}");
        }
    }



    public abstract class BaseBackendDecorator : IBackendRequestHandler
    {
        protected IBackendRequestHandler _requestHandler;

        protected BaseBackendDecorator(IBackendRequestHandler requestHandler)
        {
            _requestHandler = requestHandler;
        }

        public abstract void Handle(WebRequest request);
    }

    public class LoggingRequestDecorator : BaseBackendDecorator, IBackendRequestHandler
    {
        public LoggingRequestDecorator(IBackendRequestHandler requestHandler) : base(requestHandler)
        {
        }

        public override void Handle(WebRequest request)
        {
            if (request.isAuthenticated)
            {
                Console.WriteLine("logging reuqst" + request.body);
                this._requestHandler.Handle(request);

            }
        }
    }


    public class AuthRequestDecorator : BaseBackendDecorator, IBackendRequestHandler
    {
        public AuthRequestDecorator(IBackendRequestHandler requestHandler) : base(requestHandler)
        {
        }

        public override void Handle(WebRequest request)
        {
            if (request.isAuthenticated)
            {
                Console.WriteLine("use is authenticated");
                this._requestHandler.Handle(request);
                return;
            }

            Console.WriteLine("user is NOT authenticated");
        }

    }

}
