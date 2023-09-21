using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ComponentA
    {
        public void DoA(IMediator mediator)
        {
            Console.WriteLine("ComponenetA is doing A");
            mediator.Execute("A");
        }

        public void DoB(IMediator mediator)
        {
            Console.WriteLine("ComponenetA is doing B");
            mediator.Execute("B");
        }
    }
}
