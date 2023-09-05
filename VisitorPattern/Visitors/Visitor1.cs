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
        public void Visit(ComponentA component)
        {
            Console.WriteLine( component.Item + " Visitor1");
        }
    }
}
