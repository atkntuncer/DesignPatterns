using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Client : ITarget
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Client do its work");
        }
    }
}
