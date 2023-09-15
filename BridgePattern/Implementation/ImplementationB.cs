using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementation
{
    public class ImplementationB:IImplementation
    {
        public void Create()
        {
            Console.WriteLine("Implementation B is created");
        }
    }
}
