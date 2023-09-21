using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ComponentB
    {
        public void DoC(IMediator mediator)
        {
            Console.WriteLine("ComponenetB is doing C");
            mediator.Execute("C");
        }

        public void DoD(IMediator mediator)
        {
            Console.WriteLine("ComponenetB is doing D");
            mediator.Execute("D");
        }
    }
}
