using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Components;

namespace VisitorPattern.Visitors
{
    public class Visitor1 : IVisitor
    {
        public string VisitComponentA(ComponentA component)
        {
            component.Item = "A1";
            return component.Item + " + Visitor1";
        }

        public string VisitComponentB(ComponentB component)
        {
            component.Item = "B1";
            return component.Item + " + Visitor1";
        }
    }
}
