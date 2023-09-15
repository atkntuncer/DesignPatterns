using BridgePattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction
{
    public class ExtraAbstraction:Abstraction 
    {

        public ExtraAbstraction(IImplementation implementation):base(implementation) 
        {
        }
        public override void Operation()
        {
            Console.WriteLine("Extended operation in extended abstraction");
            base._implementation.Create();
        }
    }
}
