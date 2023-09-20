using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class HandlerA:Handler
    {
        public override void Handle(string request)
        {
            if (request=="A")
            {
                Console.WriteLine("A is handled by handlerA");
                return;
            }
            base.Handle(request);
        }
    }
}
