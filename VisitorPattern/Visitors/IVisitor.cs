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
        string VisitComponentA(ComponentA component);
        string VisitComponentB(ComponentB component);

    }
}
