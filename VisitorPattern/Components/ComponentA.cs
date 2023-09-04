using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitors;

namespace VisitorPattern.Components
{
    public class ComponentA : IComponent
    {
        public string Item { get; set; } = string.Empty;

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine(visitor.VisitComponentA(this));
        }
    }
}
