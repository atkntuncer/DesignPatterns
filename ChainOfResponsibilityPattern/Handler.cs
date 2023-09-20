using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        private Handler? _nextHandler;

        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;

            return handler;
        }

        public virtual void Handle(string request)
        {
            if (_nextHandler == null)
            {
                Console.WriteLine($"{request} isn't handled by anybody");
                return;
            }
            _nextHandler.Handle(request);
        }
    }
}
