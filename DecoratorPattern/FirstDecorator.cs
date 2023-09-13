using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FirstDecorator:Decorator
    {

        public FirstDecorator(BaseDecorator decorator):base(decorator) 
        {
        }

        public override void DoSomeWork()
        {
            base.DoSomeWork();
            Console.WriteLine("Also doing decorated work");
        }
    }
}
