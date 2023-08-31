using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    //Base class for branches and leaves
    public abstract class Component
    {
        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }

        public abstract string ToText();

    }
}
