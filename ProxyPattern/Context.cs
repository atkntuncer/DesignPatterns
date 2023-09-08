using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Context : IContext
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Doing some work in real context");
        }
    }
}
