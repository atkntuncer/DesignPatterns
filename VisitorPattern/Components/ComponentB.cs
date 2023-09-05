using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitors;

namespace VisitorPattern.Components
{
    public class ComponentB : Component
    {
        public string Item { get; set; } = "B";

        //No need anymore because it is handled in base class

        //public void Accept(IVisitor visitor)
        //{
        //   visitor.Visit(this);
        //}
    }
}
