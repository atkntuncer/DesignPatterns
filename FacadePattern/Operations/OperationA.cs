using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FacadePattern.Operations
{
    public class OperationA
    {
        public void Operate()
        {
            Console.WriteLine("Operation A is done");
        }
    }
}
