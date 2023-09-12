using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        private readonly IAdaptee _adaptee;

        public Adapter(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void DoSomeWork()
        {
            _adaptee.DoSomeWork("adapter included");
        }
    }
}
