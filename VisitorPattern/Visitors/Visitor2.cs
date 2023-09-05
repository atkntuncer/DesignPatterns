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
        public void Visit(ComponentB component)
        {
            Console.WriteLine( component.Item + " Visitor2");
        }
    }
}
