
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class HandlerC:Handler
    {
        public override void Handle(string request)
        {
            if (request == "C")
            {
                Console.WriteLine("C is handled by handlerC");
                return;
            }
            base.Handle(request);
        }
    }
}
