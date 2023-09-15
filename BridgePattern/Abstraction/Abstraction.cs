using BridgePattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction
{
    public class Abstraction
    {
        protected readonly IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }
        public virtual void Operation()
        {
            Console.WriteLine("Simple operation in abstraction");
            _implementation.Create();
        }
    }
}
