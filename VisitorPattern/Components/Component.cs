using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitors;

namespace VisitorPattern.Components
{
    public abstract class Component
    {
        public virtual void Accept(IVisitor visitor)
        {
            //Dynamic overloading - defer type selection to run time
            visitor.Visit((dynamic)this);
        }
    }
}
