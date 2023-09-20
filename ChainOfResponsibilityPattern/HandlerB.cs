using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class HandlerB:Handler
    {
        public override void Handle(string request)
        {
            if (request == "B")
            {
                Console.WriteLine("B is handled by handlerB");
                return;
            }
            base.Handle(request);
        }
    }
}
