using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //This is not mandatory. Instead of using this, decorator's methods can be used directly(Creating an interface using default
    // implementation and injecting decorators via constructor and then calling their methods )
    public abstract class Decorator : BaseDecorator
    {
        private readonly BaseDecorator _decorator;

        public Decorator(BaseDecorator decorator)
        {
            _decorator = decorator;
        }
        public override void DoSomeWork()
        {
            if (_decorator != null)
            {
                _decorator.DoSomeWork();
            }
        }
    }
}
