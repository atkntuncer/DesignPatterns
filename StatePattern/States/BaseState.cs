using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public abstract class BaseState
    {
        public abstract BaseState MoveNext();
        public abstract BaseState MovePrevious();
    }
}
