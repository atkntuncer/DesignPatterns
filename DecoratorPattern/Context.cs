using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Context : BaseDecorator
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("Doing some work in context");
        }
    }
}
