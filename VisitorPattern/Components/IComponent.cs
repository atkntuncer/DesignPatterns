using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitors;

namespace VisitorPattern.Components
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
