using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    //Branch in tree, usually has leaves or branches under itself
    public class Composite:Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string ToText()
        {
            StringBuilder sb = new();
            int count = 1;
            sb.Append("Composite");
            sb.Append("(");

            foreach (Component component in this._children) 
            {
                sb.Append(component.ToText());
                if (count != _children.Count)
                {
                    sb.Append("+");
                }
                count++;
            }
            sb.Append(')');

            return sb.ToString();
        }
    }
}
