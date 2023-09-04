using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Components;

namespace VisitorPattern.Visitors
{
    public class Visitor2 : IVisitor
    {
        public string VisitComponentA(ComponentA component)
        {
            component.Item = "A2";
            return component.Item + " + Visitor2";
        }

        public string VisitComponentB(ComponentB component)
        {
            component.Item = "B2";
            return component.Item + " + Visitor2";
        }
    }
}
