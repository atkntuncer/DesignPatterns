using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class AnotherDecorator: Decorator
    {

        public AnotherDecorator(BaseDecorator decorator):base(decorator) 
        {
        }
        public override void DoSomeWork()
        {
            base.DoSomeWork();
            Console.WriteLine("Also doing another decorated work");
        }
    }
}
