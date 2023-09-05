using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Components;

namespace VisitorPattern.Visitors
{
    public interface IVisitor
    {
        //default method for not implement everything in concrete class
        void Visit(ComponentA component) { }
        void Visit(ComponentB component) { }

    }
}
